using example;
using Semiodesk.Trinity;
using System;

namespace TrinityConsoleSample.ObjectModels
{
    [RdfClass(TEST.Persona)]
    public class Persona : Resource
    {
        [RdfProperty(TEST.CapacidadDeLiderazgo)]
        public bool CapacidadDeLiderazgo { get; set; }
        
        [RdfProperty(TEST.Desempenio)]
        public string Desempenio { get; set; }
        
        [RdfProperty(TEST.Edad)]
        public int Edad { get; set; }
        
        [RdfProperty(TEST.Habilitacion)]
        public bool Habilitacion { get; set; }
        
        [RdfProperty(TEST.Sexo)]
        public string Sexo { get; set; }
        
        public Persona(Uri uri) : base(uri) { }
    }
}
