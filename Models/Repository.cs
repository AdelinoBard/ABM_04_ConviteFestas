namespace ABM_ConviteFestas.Models {
    public static class Repository {
        private static List<ConvidadoResposta> responses = new();
        public static IEnumerable<ConvidadoResposta> Responses => responses;
        public static void AddResponse(ConvidadoResposta response) => responses.Add(response);
    }
}