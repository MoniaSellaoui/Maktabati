using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maktabati.Data.Entities;
using Maktabati.Data.Repositories;

namespace Maktabati.Services.Services
{
    public class ReservationService
    {
        private readonly ReservationRepository _reservationRepository;
        private readonly LivreRepository _livreRepository;
        private readonly MembreRepository _membreRepository;

        public ReservationService(
            ReservationRepository reservationRepository,
            LivreRepository livreRepository,
            MembreRepository membreRepository)
        {
            _reservationRepository = reservationRepository;
            _livreRepository = livreRepository;
            _membreRepository = membreRepository;
        }

        // Ajouter une réservation
        public async Task AjouterReservation(Reservation reservation)
        {
            if (reservation == null)
                throw new ArgumentNullException(nameof(reservation));

            // Vérifier si le membre existe
            var membre = await _membreRepository.GetById(reservation.MembreId);
            if (membre == null)
                throw new InvalidOperationException("Membre non trouvé.");

            // Vérifier si le livre existe
            var livre = await _livreRepository.GetById(reservation.LivreId);
            if (livre == null)
                throw new InvalidOperationException("Livre non trouvé.");

            // Vérifier si le livre est déjà réservé
            var reservationsExistantes = await _reservationRepository.GetReservationsByLivreId(reservation.LivreId);
            if (reservationsExistantes.Any(r => r.Statut == "Active"))
                throw new InvalidOperationException("Ce livre est déjà réservé.");

            // Ajouter la réservation
            reservation.DateReservation = DateTime.Now;
            reservation.Statut = "Active";
            await _reservationRepository.Add(reservation);
        }

        // Annuler une réservation
        public async Task AnnulerReservation(int reservationId)
        {
            var reservation = await _reservationRepository.GetById(reservationId);
            if (reservation == null)
                throw new InvalidOperationException("Réservation non trouvée.");

            // Mettre à jour le statut de la réservation
            reservation.Statut = "Annulée";
            await _reservationRepository.Update(reservation);
        }

        // Récupérer les réservations d'un membre
        public async Task<List<Reservation>> ObtenirReservationsParMembre(int membreId)
        {
            return await _reservationRepository.GetReservationsByMembreId(membreId);
        }

        // Récupérer les réservations actives d'un livre
        public async Task<List<Reservation>> ObtenirReservationsActivesParLivre(int livreId)
        {
            var reservations = await _reservationRepository.GetReservationsByLivreId(livreId);
            return reservations.Where(r => r.Statut == "Active").ToList();
        }

        // Marquer une réservation comme terminée
        public async Task TerminerReservation(int reservationId)
        {
            var reservation = await _reservationRepository.GetById(reservationId);
            if (reservation == null)
                throw new InvalidOperationException("Réservation non trouvée.");

            // Mettre à jour le statut de la réservation
            reservation.Statut = "Terminée";
            await _reservationRepository.Update(reservation);
        }
    }
}