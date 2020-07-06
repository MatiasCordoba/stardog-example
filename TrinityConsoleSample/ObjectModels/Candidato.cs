using example;
using Semiodesk.Trinity;
using System;

namespace TrinityConsoleSample.ObjectModels
{
    [RdfClass(TEST.Candidato)]
    public class Candidato : Resource
    {
        public Candidato(Uri uri) : base(uri) { }
    }
}
