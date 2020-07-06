using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Semiodesk.Trinity;
using Semiodesk.Trinity.Store;
using TrinityConsoleSample.ObjectModels;

namespace TrinityConsoleSample
{
    class Program
    {
        const string OntologyNamespace = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#";
        static IModel Model { get; set; }

        static void Main(string[] args)
        {
            const string connectionString = "provider=stardog;host=http://localhost:5820;uid=admin;pw=admin;sid=Test";

            OntologyDiscovery.AddAssembly(Assembly.GetExecutingAssembly());
            MappingDiscovery.RegisterCallingAssembly();

            #region ---------------- Stardog init ----------------------

            // Load the stardog store provider
            StoreFactory.LoadProvider<StardogStoreProvider>();

            // Connect to the stardog store
            IStore store = StoreFactory.CreateStore(connectionString);
            store.InitializeFromConfiguration(Path.Combine(Environment.CurrentDirectory, "ontologies.config"));

            // A model (named graph) is where we collect resources that logically belong together
            Model = store.GetModel(
                new Uri(OntologyNamespace));

            #endregion

            #region ---------------- using LINQ ---------------- 

            Console.WriteLine("Using LINQ");
            
            // With reasoning
            var withReasoning = Model.AsQueryable<CandidatoEquipoDesarrollo>(true);

            Console.WriteLine(
                $"With reasoning enabled, the artists query returned {withReasoning.Count()} records");
            
            // Without reasoning
            var withoutReasoning = Model.AsQueryable<CandidatoEquipoDesarrollo>(false);

            Console.WriteLine(
                $"With reasoning disabled, the artists query returned {withoutReasoning.Count()} records");

            #endregion
            
            #region ---------------- using - SPARQL ---------------- 

            Console.WriteLine("Using SPARQL");

            var sparqlQuery = new SparqlQuery(@"
                  select distinct ?candidato
                  where {{ ?candidato a :CandidatoEquipoDesarrollo }}");

            var candidates = Model.GetBindings(sparqlQuery, true).ToList();

            if (candidates.Count > 0)
            {
                Console.WriteLine($"Found {candidates.Count} matching candidates");

                foreach (var candidate in candidates)
                {
                    Console.WriteLine($"\tCandidate: {NameFormatter(candidate.Values.FirstOrDefault()?.ToString())}");
                }
            }

            #endregion

            #region ---------------- Modify ----------------
            // Persona camila = Model.GetResource<Persona>(new Uri(TEST.Camila));
            // camila.Edad = 31;
            // camila.Commit();
            #endregion
        }

        /// <summary>
        /// Format the answer to return a better string
        /// </summary>
        /// <param name="s">the string to format</param>
        /// <returns>the formatted string</returns>
        private static string NameFormatter(string s)
        {
            return s.Replace(OntologyNamespace, "");
        }
    }
}