using example;
using Semiodesk.Trinity;
using System;

namespace TrinityConsoleSample.ObjectModels
{
    [RdfClass(TEST.CandidatoEquipoDesarrollo)]
    public class CandidatoEquipoDesarrollo : Resource
    {
        public CandidatoEquipoDesarrollo(Uri uri) : base(uri) { }
    }
}
