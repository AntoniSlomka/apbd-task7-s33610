namespace APBD_Task_7.DTOs
{
    public class RentalResponseDTO
    {
        public int Id { get; set; }

        public DateTime RentalDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public string Status { get; set; } = string.Empty;

        public List<RentalMovieResponseDTO>? Movies { get; set; }


    }
}
