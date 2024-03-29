﻿namespace Systekna.Core.ValueObject
{
    public readonly struct Bloqueio(bool flAtivo = true, DateTime? dtBloqueio = null)
    {
        public readonly bool FlAtivo = flAtivo;

        public readonly DateTime? DtBloqueio = dtBloqueio;

        public static implicit operator Bloqueio(bool ativo)
            => new Bloqueio(ativo, ativo == true ? null : DateTime.Now);

        public override string ToString() 
            => FlAtivo == true ? "ATIVO" : $"BLOQUEADO {DtBloqueio}";
    }
}