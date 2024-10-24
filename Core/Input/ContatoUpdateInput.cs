﻿namespace Core.Input
{
    public class ContatoUpdateInput
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required int DDD { get; set; }
        public required int Telefone { get; set; }
        public string? Email { get; set; }
    }
}
