namespace ABM_ConviteFestas.Models {
    public class ConvidadoResposta {
    
        [Required(ErrorMessage = "Por favor, informe seu nome")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Por favor, informe seu email")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Por favor, informe seu telefone")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Por favor, confirme sua presença")]
        public bool? WillAttend { get; set; }
    }
}