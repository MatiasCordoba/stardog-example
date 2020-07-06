// Attention: This file is generated. Any modifications will eventually be overwritten.
// Date: 5/7/2020 22:25:21

using System;
using System.Collections.Generic;
using System.Text;
using Semiodesk.Trinity;

namespace example
{
	
///<summary>
///Semiodesk.Trinity.BindingSet
///
///</summary>
public class rdf : Ontology
{
    public static readonly Uri Namespace = new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "rdf";
    public static string GetPrefix() { return Prefix; }     

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#"/>
    ///</summary>
    public static readonly Resource _22_rdf_syntax_ns = new Resource(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#"));    

    ///<summary>
    ///The datatype of RDF literals storing fragments of HTML content
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#HTML"/>
    ///</summary>
    public static readonly Resource HTML = new Resource(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#HTML"));    

    ///<summary>
    ///The datatype of language-tagged string values
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#langString"/>
    ///</summary>
    public static readonly Resource langString = new Resource(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#langString"));    

    ///<summary>
    ///The class of plain (i.e. untyped) literal values, as used in RIF and OWL 2
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral"/>
    ///</summary>
    public static readonly Resource PlainLiteral = new Resource(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral"));    

    ///<summary>
    ///The subject is an instance of a class.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#type"/>
    ///</summary>
    public static readonly Property type = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#type"));    

    ///<summary>
    ///The class of RDF properties.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Property"/>
    ///</summary>
    public static readonly Class Property = new Class(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#Property"));    

    ///<summary>
    ///The class of RDF statements.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement"/>
    ///</summary>
    public static readonly Class Statement = new Class(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement"));    

    ///<summary>
    ///The subject of the subject RDF statement.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#subject"/>
    ///</summary>
    public static readonly Property subject = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#subject"));    

    ///<summary>
    ///The predicate of the subject RDF statement.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate"/>
    ///</summary>
    public static readonly Property predicate = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate"));    

    ///<summary>
    ///The object of the subject RDF statement.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#object"/>
    ///</summary>
    public static readonly Property _object = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#object"));    

    ///<summary>
    ///The class of unordered containers.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag"/>
    ///</summary>
    public static readonly Class Bag = new Class(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag"));    

    ///<summary>
    ///The class of ordered containers.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq"/>
    ///</summary>
    public static readonly Class Seq = new Class(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq"));    

    ///<summary>
    ///The class of containers of alternatives.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt"/>
    ///</summary>
    public static readonly Class Alt = new Class(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt"));    

    ///<summary>
    ///Idiomatic property used for structured values.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#value"/>
    ///</summary>
    public static readonly Property value = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#value"));    

    ///<summary>
    ///The class of RDF Lists.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#List"/>
    ///</summary>
    public static readonly Class List = new Class(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#List"));    

    ///<summary>
    ///The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#nil"/>
    ///</summary>
    public static readonly Resource nil = new Resource(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#nil"));    

    ///<summary>
    ///The first item in the subject RDF list.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#first"/>
    ///</summary>
    public static readonly Property first = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#first"));    

    ///<summary>
    ///The rest of the subject RDF list after the first item.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#rest"/>
    ///</summary>
    public static readonly Property rest = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#rest"));    

    ///<summary>
    ///The datatype of XML literal values.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral"/>
    ///</summary>
    public static readonly Resource XMLLiteral = new Resource(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral"));
}
///<summary>
///Semiodesk.Trinity.BindingSet
///
///</summary>
public static class RDF
{
    public static readonly Uri Namespace = new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "RDF";
    public static string GetPrefix() { return Prefix; } 

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#"/>
    ///</summary>
    public const string _22_rdf_syntax_ns = "http://www.w3.org/1999/02/22-rdf-syntax-ns#";

    ///<summary>
    ///The datatype of RDF literals storing fragments of HTML content
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#HTML"/>
    ///</summary>
    public const string HTML = "http://www.w3.org/1999/02/22-rdf-syntax-ns#HTML";

    ///<summary>
    ///The datatype of language-tagged string values
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#langString"/>
    ///</summary>
    public const string langString = "http://www.w3.org/1999/02/22-rdf-syntax-ns#langString";

    ///<summary>
    ///The class of plain (i.e. untyped) literal values, as used in RIF and OWL 2
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral"/>
    ///</summary>
    public const string PlainLiteral = "http://www.w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral";

    ///<summary>
    ///The subject is an instance of a class.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#type"/>
    ///</summary>
    public const string type = "http://www.w3.org/1999/02/22-rdf-syntax-ns#type";

    ///<summary>
    ///The class of RDF properties.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Property"/>
    ///</summary>
    public const string Property = "http://www.w3.org/1999/02/22-rdf-syntax-ns#Property";

    ///<summary>
    ///The class of RDF statements.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement"/>
    ///</summary>
    public const string Statement = "http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement";

    ///<summary>
    ///The subject of the subject RDF statement.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#subject"/>
    ///</summary>
    public const string subject = "http://www.w3.org/1999/02/22-rdf-syntax-ns#subject";

    ///<summary>
    ///The predicate of the subject RDF statement.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate"/>
    ///</summary>
    public const string predicate = "http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate";

    ///<summary>
    ///The object of the subject RDF statement.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#object"/>
    ///</summary>
    public const string _object = "http://www.w3.org/1999/02/22-rdf-syntax-ns#object";

    ///<summary>
    ///The class of unordered containers.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag"/>
    ///</summary>
    public const string Bag = "http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag";

    ///<summary>
    ///The class of ordered containers.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq"/>
    ///</summary>
    public const string Seq = "http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq";

    ///<summary>
    ///The class of containers of alternatives.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt"/>
    ///</summary>
    public const string Alt = "http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt";

    ///<summary>
    ///Idiomatic property used for structured values.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#value"/>
    ///</summary>
    public const string value = "http://www.w3.org/1999/02/22-rdf-syntax-ns#value";

    ///<summary>
    ///The class of RDF Lists.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#List"/>
    ///</summary>
    public const string List = "http://www.w3.org/1999/02/22-rdf-syntax-ns#List";

    ///<summary>
    ///The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#nil"/>
    ///</summary>
    public const string nil = "http://www.w3.org/1999/02/22-rdf-syntax-ns#nil";

    ///<summary>
    ///The first item in the subject RDF list.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#first"/>
    ///</summary>
    public const string first = "http://www.w3.org/1999/02/22-rdf-syntax-ns#first";

    ///<summary>
    ///The rest of the subject RDF list after the first item.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#rest"/>
    ///</summary>
    public const string rest = "http://www.w3.org/1999/02/22-rdf-syntax-ns#rest";

    ///<summary>
    ///The datatype of XML literal values.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral"/>
    ///</summary>
    public const string XMLLiteral = "http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral";
}
///<summary>
///Semiodesk.Trinity.BindingSet
///
///</summary>
public class rdfs : Ontology
{
    public static readonly Uri Namespace = new Uri("http://www.w3.org/2000/01/rdf-schema#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "rdfs";
    public static string GetPrefix() { return Prefix; }     

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#"/>
    ///</summary>
    public static readonly Resource rdf_schema = new Resource(new Uri("http://www.w3.org/2000/01/rdf-schema#"));    

    ///<summary>
    ///The class resource, everything.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Resource"/>
    ///</summary>
    public static readonly Class Resource = new Class(new Uri("http://www.w3.org/2000/01/rdf-schema#Resource"));    

    ///<summary>
    ///The class of classes.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Class"/>
    ///</summary>
    public static readonly Class Class = new Class(new Uri("http://www.w3.org/2000/01/rdf-schema#Class"));    

    ///<summary>
    ///The subject is a subclass of a class.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#subClassOf"/>
    ///</summary>
    public static readonly Property subClassOf = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#subClassOf"));    

    ///<summary>
    ///The subject is a subproperty of a property.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#subPropertyOf"/>
    ///</summary>
    public static readonly Property subPropertyOf = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#subPropertyOf"));    

    ///<summary>
    ///A description of the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#comment"/>
    ///</summary>
    public static readonly Property comment = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#comment"));    

    ///<summary>
    ///A human-readable name for the subject.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#label"/>
    ///</summary>
    public static readonly Property label = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#label"));    

    ///<summary>
    ///A domain of the subject property.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#domain"/>
    ///</summary>
    public static readonly Property domain = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#domain"));    

    ///<summary>
    ///A range of the subject property.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#range"/>
    ///</summary>
    public static readonly Property range = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#range"));    

    ///<summary>
    ///Further information about the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#seeAlso"/>
    ///</summary>
    public static readonly Property seeAlso = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#seeAlso"));    

    ///<summary>
    ///The defininition of the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#isDefinedBy"/>
    ///</summary>
    public static readonly Property isDefinedBy = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#isDefinedBy"));    

    ///<summary>
    ///The class of literal values, eg. textual strings and integers.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Literal"/>
    ///</summary>
    public static readonly Class Literal = new Class(new Uri("http://www.w3.org/2000/01/rdf-schema#Literal"));    

    ///<summary>
    ///The class of RDF containers.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Container"/>
    ///</summary>
    public static readonly Class Container = new Class(new Uri("http://www.w3.org/2000/01/rdf-schema#Container"));    

    ///<summary>
    ///The class of container membership properties, rdf:_1, rdf:_2, ...,
    ///                    all of which are sub-properties of 'member'.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty"/>
    ///</summary>
    public static readonly Class ContainerMembershipProperty = new Class(new Uri("http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty"));    

    ///<summary>
    ///A member of the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#member"/>
    ///</summary>
    public static readonly Property member = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#member"));    

    ///<summary>
    ///The class of RDF datatypes.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Datatype"/>
    ///</summary>
    public static readonly Class Datatype = new Class(new Uri("http://www.w3.org/2000/01/rdf-schema#Datatype"));
}
///<summary>
///Semiodesk.Trinity.BindingSet
///
///</summary>
public static class RDFS
{
    public static readonly Uri Namespace = new Uri("http://www.w3.org/2000/01/rdf-schema#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "RDFS";
    public static string GetPrefix() { return Prefix; } 

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#"/>
    ///</summary>
    public const string rdf_schema = "http://www.w3.org/2000/01/rdf-schema#";

    ///<summary>
    ///The class resource, everything.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Resource"/>
    ///</summary>
    public const string Resource = "http://www.w3.org/2000/01/rdf-schema#Resource";

    ///<summary>
    ///The class of classes.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Class"/>
    ///</summary>
    public const string Class = "http://www.w3.org/2000/01/rdf-schema#Class";

    ///<summary>
    ///The subject is a subclass of a class.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#subClassOf"/>
    ///</summary>
    public const string subClassOf = "http://www.w3.org/2000/01/rdf-schema#subClassOf";

    ///<summary>
    ///The subject is a subproperty of a property.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#subPropertyOf"/>
    ///</summary>
    public const string subPropertyOf = "http://www.w3.org/2000/01/rdf-schema#subPropertyOf";

    ///<summary>
    ///A description of the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#comment"/>
    ///</summary>
    public const string comment = "http://www.w3.org/2000/01/rdf-schema#comment";

    ///<summary>
    ///A human-readable name for the subject.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#label"/>
    ///</summary>
    public const string label = "http://www.w3.org/2000/01/rdf-schema#label";

    ///<summary>
    ///A domain of the subject property.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#domain"/>
    ///</summary>
    public const string domain = "http://www.w3.org/2000/01/rdf-schema#domain";

    ///<summary>
    ///A range of the subject property.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#range"/>
    ///</summary>
    public const string range = "http://www.w3.org/2000/01/rdf-schema#range";

    ///<summary>
    ///Further information about the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#seeAlso"/>
    ///</summary>
    public const string seeAlso = "http://www.w3.org/2000/01/rdf-schema#seeAlso";

    ///<summary>
    ///The defininition of the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#isDefinedBy"/>
    ///</summary>
    public const string isDefinedBy = "http://www.w3.org/2000/01/rdf-schema#isDefinedBy";

    ///<summary>
    ///The class of literal values, eg. textual strings and integers.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Literal"/>
    ///</summary>
    public const string Literal = "http://www.w3.org/2000/01/rdf-schema#Literal";

    ///<summary>
    ///The class of RDF containers.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Container"/>
    ///</summary>
    public const string Container = "http://www.w3.org/2000/01/rdf-schema#Container";

    ///<summary>
    ///The class of container membership properties, rdf:_1, rdf:_2, ...,
    ///                    all of which are sub-properties of 'member'.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty"/>
    ///</summary>
    public const string ContainerMembershipProperty = "http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty";

    ///<summary>
    ///A member of the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#member"/>
    ///</summary>
    public const string member = "http://www.w3.org/2000/01/rdf-schema#member";

    ///<summary>
    ///The class of RDF datatypes.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Datatype"/>
    ///</summary>
    public const string Datatype = "http://www.w3.org/2000/01/rdf-schema#Datatype";
}
///<summary>
///
///
///</summary>
public class Test : Ontology
{
    public static readonly Uri Namespace = new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "Test";
    public static string GetPrefix() { return Prefix; }     

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4"/>
    ///</summary>
    public static readonly Resource untitled_ontology_4 = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#DependeDe"/>
    ///</summary>
    public static readonly Property DependeDe = new Property(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#DependeDe"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Puesto"/>
    ///</summary>
    public static readonly Class Puesto = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Puesto"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#TieneACargo"/>
    ///</summary>
    public static readonly Property TieneACargo = new Property(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#TieneACargo"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Dirige"/>
    ///</summary>
    public static readonly Property Dirige = new Property(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Dirige"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Equipo"/>
    ///</summary>
    public static readonly Class Equipo = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Equipo"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EsDirigidoPor"/>
    ///</summary>
    public static readonly Property EsDirigidoPor = new Property(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EsDirigidoPor"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EsDesempeniadoPor"/>
    ///</summary>
    public static readonly Property EsDesempeniadoPor = new Property(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EsDesempeniadoPor"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Persona"/>
    ///</summary>
    public static readonly Class Persona = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Persona"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SeDesempeniaComo"/>
    ///</summary>
    public static readonly Property SeDesempeniaComo = new Property(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SeDesempeniaComo"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EstaCompuestoPor"/>
    ///</summary>
    public static readonly Property EstaCompuestoPor = new Property(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EstaCompuestoPor"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Pertenece"/>
    ///</summary>
    public static readonly Property Pertenece = new Property(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Pertenece"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#TieneAsignado"/>
    ///</summary>
    public static readonly Property TieneAsignado = new Property(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#TieneAsignado"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Proyecto"/>
    ///</summary>
    public static readonly Class Proyecto = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Proyecto"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#TrabajaEn"/>
    ///</summary>
    public static readonly Property TrabajaEn = new Property(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#TrabajaEn"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#AspectosEvaluar"/>
    ///</summary>
    public static readonly Property AspectosEvaluar = new Property(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#AspectosEvaluar"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CapacidadDeLiderazgo"/>
    ///</summary>
    public static readonly Property CapacidadDeLiderazgo = new Property(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CapacidadDeLiderazgo"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Desempenio"/>
    ///</summary>
    public static readonly Property Desempenio = new Property(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Desempenio"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Edad"/>
    ///</summary>
    public static readonly Property Edad = new Property(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Edad"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Habilitacion"/>
    ///</summary>
    public static readonly Property Habilitacion = new Property(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Habilitacion"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Sexo"/>
    ///</summary>
    public static readonly Property Sexo = new Property(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Sexo"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Candidato"/>
    ///</summary>
    public static readonly Class Candidato = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Candidato"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoDirector"/>
    ///</summary>
    public static readonly Class CandidatoDirector = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoDirector"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoDesarrollo"/>
    ///</summary>
    public static readonly Class CandidatoEquipoDesarrollo = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoDesarrollo"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoDesarrolloConExperiencia"/>
    ///</summary>
    public static readonly Class CandidatoEquipoDesarrolloConExperiencia = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoDesarrolloConExperiencia"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoDesarrolloSinExperiencia"/>
    ///</summary>
    public static readonly Class CandidatoEquipoDesarrolloSinExperiencia = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoDesarrolloSinExperiencia"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoMantenimiento"/>
    ///</summary>
    public static readonly Class CandidatoEquipoMantenimiento = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoMantenimiento"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoMantenimientoConExperiencia"/>
    ///</summary>
    public static readonly Class CandidatoEquipoMantenimientoConExperiencia = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoMantenimientoConExperiencia"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoMantenimientoSinExperiencia"/>
    ///</summary>
    public static readonly Class CandidatoEquipoMantenimientoSinExperiencia = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoMantenimientoSinExperiencia"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoServicio"/>
    ///</summary>
    public static readonly Class CandidatoEquipoServicio = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoServicio"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoServicioConExperiencia"/>
    ///</summary>
    public static readonly Class CandidatoEquipoServicioConExperiencia = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoServicioConExperiencia"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoServicioSinExperiencia"/>
    ///</summary>
    public static readonly Class CandidatoEquipoServicioSinExperiencia = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoServicioSinExperiencia"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoJefaServicio"/>
    ///</summary>
    public static readonly Class CandidatoJefaServicio = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoJefaServicio"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoJefeMantenimiento"/>
    ///</summary>
    public static readonly Class CandidatoJefeMantenimiento = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoJefeMantenimiento"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoJefeMantenimientoConPrioridad"/>
    ///</summary>
    public static readonly Class CandidatoJefeMantenimientoConPrioridad = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoJefeMantenimientoConPrioridad"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoSubdirector"/>
    ///</summary>
    public static readonly Class CandidatoSubdirector = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoSubdirector"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoSubjefaServicio"/>
    ///</summary>
    public static readonly Class CandidatoSubjefaServicio = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoSubjefaServicio"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoSubjefaServicioConPrioridad"/>
    ///</summary>
    public static readonly Class CandidatoSubjefaServicioConPrioridad = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoSubjefaServicioConPrioridad"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Director"/>
    ///</summary>
    public static readonly Class Director = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Director"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Subdirector"/>
    ///</summary>
    public static readonly Class Subdirector = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Subdirector"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoDesarrollo"/>
    ///</summary>
    public static readonly Class EquipoDesarrollo = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoDesarrollo"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoDesarrolloConExperiencia"/>
    ///</summary>
    public static readonly Class EquipoDesarrolloConExperiencia = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoDesarrolloConExperiencia"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoDesarrolloSinExperiencia"/>
    ///</summary>
    public static readonly Class EquipoDesarrolloSinExperiencia = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoDesarrolloSinExperiencia"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoMantenimiento"/>
    ///</summary>
    public static readonly Class EquipoMantenimiento = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoMantenimiento"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefeMantenimiento"/>
    ///</summary>
    public static readonly Class JefeMantenimiento = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefeMantenimiento"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoMantenimientoConExperiencia"/>
    ///</summary>
    public static readonly Class EquipoMantenimientoConExperiencia = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoMantenimientoConExperiencia"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoMantenimientoSinExperiencia"/>
    ///</summary>
    public static readonly Class EquipoMantenimientoSinExperiencia = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoMantenimientoSinExperiencia"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoServicio"/>
    ///</summary>
    public static readonly Class EquipoServicio = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoServicio"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubjefaServicio"/>
    ///</summary>
    public static readonly Class SubjefaServicio = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubjefaServicio"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefaServicio"/>
    ///</summary>
    public static readonly Class JefaServicio = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefaServicio"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoServicioConExperiencia"/>
    ///</summary>
    public static readonly Class EquipoServicioConExperiencia = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoServicioConExperiencia"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoServicioSinExperiencia"/>
    ///</summary>
    public static readonly Class EquipoServicioSinExperiencia = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoServicioSinExperiencia"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#ProyectoA"/>
    ///</summary>
    public static readonly Class ProyectoA = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#ProyectoA"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#ProyectoB"/>
    ///</summary>
    public static readonly Class ProyectoB = new Class(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#ProyectoB"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Camila"/>
    ///</summary>
    public static readonly Resource Camila = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Camila"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Carlos"/>
    ///</summary>
    public static readonly Resource Carlos = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Carlos"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoVerdeNoExperimentado"/>
    ///</summary>
    public static readonly Resource EquipoVerdeNoExperimentado = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoVerdeNoExperimentado"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Celeste"/>
    ///</summary>
    public static readonly Resource Celeste = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Celeste"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Daniela"/>
    ///</summary>
    public static readonly Resource Daniela = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Daniela"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoAzulNoExperimentado"/>
    ///</summary>
    public static readonly Resource EquipoAzulNoExperimentado = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoAzulNoExperimentado"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Dante"/>
    ///</summary>
    public static readonly Resource Dante = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Dante"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Dario"/>
    ///</summary>
    public static readonly Resource Dario = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Dario"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefeDeMantenimientoEquipoNoExperimentado"/>
    ///</summary>
    public static readonly Resource JefeDeMantenimientoEquipoNoExperimentado = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefeDeMantenimientoEquipoNoExperimentado"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Diego"/>
    ///</summary>
    public static readonly Resource Diego = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Diego"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#DirectorEquipoRojoExperimentado"/>
    ///</summary>
    public static readonly Resource DirectorEquipoRojoExperimentado = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#DirectorEquipoRojoExperimentado"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoRojoExperimentado"/>
    ///</summary>
    public static readonly Resource EquipoRojoExperimentado = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoRojoExperimentado"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubdirectorEquipoRojoExperimentado"/>
    ///</summary>
    public static readonly Resource SubdirectorEquipoRojoExperimentado = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubdirectorEquipoRojoExperimentado"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#DirectorEquipoRojoNoExperimentado"/>
    ///</summary>
    public static readonly Resource DirectorEquipoRojoNoExperimentado = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#DirectorEquipoRojoNoExperimentado"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoRojoNoExperimentado"/>
    ///</summary>
    public static readonly Resource EquipoRojoNoExperimentado = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoRojoNoExperimentado"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubdirectorEquipoRojoNoExperimentado"/>
    ///</summary>
    public static readonly Resource SubdirectorEquipoRojoNoExperimentado = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubdirectorEquipoRojoNoExperimentado"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Edgardo"/>
    ///</summary>
    public static readonly Resource Edgardo = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Edgardo"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoAzulExperimentado"/>
    ///</summary>
    public static readonly Resource EquipoAzulExperimentado = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoAzulExperimentado"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Gladis"/>
    ///</summary>
    public static readonly Resource Gladis = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Gladis"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefaDeServicioEquipoExperimentado"/>
    ///</summary>
    public static readonly Resource JefaDeServicioEquipoExperimentado = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefaDeServicioEquipoExperimentado"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefaDeServicioEquipoNoExperimentado"/>
    ///</summary>
    public static readonly Resource JefaDeServicioEquipoNoExperimentado = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefaDeServicioEquipoNoExperimentado"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Proyecto2"/>
    ///</summary>
    public static readonly Resource Proyecto2 = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Proyecto2"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Rolando"/>
    ///</summary>
    public static readonly Resource Rolando = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Rolando"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Romina"/>
    ///</summary>
    public static readonly Resource Romina = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Romina"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Sebastian"/>
    ///</summary>
    public static readonly Resource Sebastian = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Sebastian"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Valeria"/>
    ///</summary>
    public static readonly Resource Valeria = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Valeria"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Laura"/>
    ///</summary>
    public static readonly Resource Laura = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Laura"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Pedro"/>
    ///</summary>
    public static readonly Resource Pedro = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Pedro"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Proyecto1"/>
    ///</summary>
    public static readonly Resource Proyecto1 = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Proyecto1"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoVerdeExperimentado"/>
    ///</summary>
    public static readonly Resource EquipoVerdeExperimentado = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoVerdeExperimentado"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefeDeMantenimientoEquipoExperimentado"/>
    ///</summary>
    public static readonly Resource JefeDeMantenimientoEquipoExperimentado = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefeDeMantenimientoEquipoExperimentado"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Nicolas"/>
    ///</summary>
    public static readonly Resource Nicolas = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Nicolas"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Marcelo"/>
    ///</summary>
    public static readonly Resource Marcelo = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Marcelo"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Matias"/>
    ///</summary>
    public static readonly Resource Matias = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Matias"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Fabiana"/>
    ///</summary>
    public static readonly Resource Fabiana = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Fabiana"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubjefaDeServicioEquipoExperimentado"/>
    ///</summary>
    public static readonly Resource SubjefaDeServicioEquipoExperimentado = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubjefaDeServicioEquipoExperimentado"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Gisela"/>
    ///</summary>
    public static readonly Resource Gisela = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Gisela"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Jorge"/>
    ///</summary>
    public static readonly Resource Jorge = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Jorge"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Juan"/>
    ///</summary>
    public static readonly Resource Juan = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Juan"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Mariel"/>
    ///</summary>
    public static readonly Resource Mariel = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Mariel"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubjefaDeServicioEquipoNoExperimentado"/>
    ///</summary>
    public static readonly Resource SubjefaDeServicioEquipoNoExperimentado = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubjefaDeServicioEquipoNoExperimentado"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Maximiliano"/>
    ///</summary>
    public static readonly Resource Maximiliano = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Maximiliano"));    

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Vanina"/>
    ///</summary>
    public static readonly Resource Vanina = new Resource(new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Vanina"));    

    ///<summary>
    ///
    ///<see cref="urn:swrl#x"/>
    ///</summary>
    public static readonly Resource x = new Resource(new Uri("urn:swrl#x"));    

    ///<summary>
    ///
    ///<see cref="urn:swrl#y"/>
    ///</summary>
    public static readonly Resource y = new Resource(new Uri("urn:swrl#y"));    

    ///<summary>
    ///
    ///<see cref="urn:swrl#z"/>
    ///</summary>
    public static readonly Resource z = new Resource(new Uri("urn:swrl#z"));    

    ///<summary>
    ///
    ///<see cref="urn:swrl#w"/>
    ///</summary>
    public static readonly Resource w = new Resource(new Uri("urn:swrl#w"));    

    ///<summary>
    ///
    ///<see cref="urn:swrl#e"/>
    ///</summary>
    public static readonly Resource e = new Resource(new Uri("urn:swrl#e"));    

    ///<summary>
    ///
    ///<see cref="urn:swrl#h"/>
    ///</summary>
    public static readonly Resource h = new Resource(new Uri("urn:swrl#h"));    

    ///<summary>
    ///
    ///<see cref="urn:swrl#b"/>
    ///</summary>
    public static readonly Resource b = new Resource(new Uri("urn:swrl#b"));    

    ///<summary>
    ///
    ///<see cref="urn:swrl#p"/>
    ///</summary>
    public static readonly Resource p = new Resource(new Uri("urn:swrl#p"));    

    ///<summary>
    ///
    ///<see cref="urn:swrl#s"/>
    ///</summary>
    public static readonly Resource s = new Resource(new Uri("urn:swrl#s"));
}
///<summary>
///
///
///</summary>
public static class TEST
{
    public static readonly Uri Namespace = new Uri("http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "TEST";
    public static string GetPrefix() { return Prefix; } 

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4"/>
    ///</summary>
    public const string untitled_ontology_4 = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#DependeDe"/>
    ///</summary>
    public const string DependeDe = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#DependeDe";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Puesto"/>
    ///</summary>
    public const string Puesto = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Puesto";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#TieneACargo"/>
    ///</summary>
    public const string TieneACargo = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#TieneACargo";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Dirige"/>
    ///</summary>
    public const string Dirige = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Dirige";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Equipo"/>
    ///</summary>
    public const string Equipo = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Equipo";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EsDirigidoPor"/>
    ///</summary>
    public const string EsDirigidoPor = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EsDirigidoPor";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EsDesempeniadoPor"/>
    ///</summary>
    public const string EsDesempeniadoPor = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EsDesempeniadoPor";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Persona"/>
    ///</summary>
    public const string Persona = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Persona";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SeDesempeniaComo"/>
    ///</summary>
    public const string SeDesempeniaComo = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SeDesempeniaComo";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EstaCompuestoPor"/>
    ///</summary>
    public const string EstaCompuestoPor = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EstaCompuestoPor";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Pertenece"/>
    ///</summary>
    public const string Pertenece = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Pertenece";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#TieneAsignado"/>
    ///</summary>
    public const string TieneAsignado = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#TieneAsignado";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Proyecto"/>
    ///</summary>
    public const string Proyecto = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Proyecto";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#TrabajaEn"/>
    ///</summary>
    public const string TrabajaEn = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#TrabajaEn";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#AspectosEvaluar"/>
    ///</summary>
    public const string AspectosEvaluar = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#AspectosEvaluar";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CapacidadDeLiderazgo"/>
    ///</summary>
    public const string CapacidadDeLiderazgo = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CapacidadDeLiderazgo";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Desempenio"/>
    ///</summary>
    public const string Desempenio = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Desempenio";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Edad"/>
    ///</summary>
    public const string Edad = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Edad";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Habilitacion"/>
    ///</summary>
    public const string Habilitacion = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Habilitacion";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Sexo"/>
    ///</summary>
    public const string Sexo = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Sexo";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Candidato"/>
    ///</summary>
    public const string Candidato = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Candidato";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoDirector"/>
    ///</summary>
    public const string CandidatoDirector = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoDirector";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoDesarrollo"/>
    ///</summary>
    public const string CandidatoEquipoDesarrollo = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoDesarrollo";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoDesarrolloConExperiencia"/>
    ///</summary>
    public const string CandidatoEquipoDesarrolloConExperiencia = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoDesarrolloConExperiencia";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoDesarrolloSinExperiencia"/>
    ///</summary>
    public const string CandidatoEquipoDesarrolloSinExperiencia = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoDesarrolloSinExperiencia";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoMantenimiento"/>
    ///</summary>
    public const string CandidatoEquipoMantenimiento = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoMantenimiento";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoMantenimientoConExperiencia"/>
    ///</summary>
    public const string CandidatoEquipoMantenimientoConExperiencia = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoMantenimientoConExperiencia";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoMantenimientoSinExperiencia"/>
    ///</summary>
    public const string CandidatoEquipoMantenimientoSinExperiencia = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoMantenimientoSinExperiencia";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoServicio"/>
    ///</summary>
    public const string CandidatoEquipoServicio = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoServicio";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoServicioConExperiencia"/>
    ///</summary>
    public const string CandidatoEquipoServicioConExperiencia = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoServicioConExperiencia";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoServicioSinExperiencia"/>
    ///</summary>
    public const string CandidatoEquipoServicioSinExperiencia = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoEquipoServicioSinExperiencia";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoJefaServicio"/>
    ///</summary>
    public const string CandidatoJefaServicio = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoJefaServicio";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoJefeMantenimiento"/>
    ///</summary>
    public const string CandidatoJefeMantenimiento = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoJefeMantenimiento";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoJefeMantenimientoConPrioridad"/>
    ///</summary>
    public const string CandidatoJefeMantenimientoConPrioridad = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoJefeMantenimientoConPrioridad";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoSubdirector"/>
    ///</summary>
    public const string CandidatoSubdirector = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoSubdirector";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoSubjefaServicio"/>
    ///</summary>
    public const string CandidatoSubjefaServicio = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoSubjefaServicio";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoSubjefaServicioConPrioridad"/>
    ///</summary>
    public const string CandidatoSubjefaServicioConPrioridad = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#CandidatoSubjefaServicioConPrioridad";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Director"/>
    ///</summary>
    public const string Director = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Director";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Subdirector"/>
    ///</summary>
    public const string Subdirector = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Subdirector";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoDesarrollo"/>
    ///</summary>
    public const string EquipoDesarrollo = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoDesarrollo";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoDesarrolloConExperiencia"/>
    ///</summary>
    public const string EquipoDesarrolloConExperiencia = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoDesarrolloConExperiencia";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoDesarrolloSinExperiencia"/>
    ///</summary>
    public const string EquipoDesarrolloSinExperiencia = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoDesarrolloSinExperiencia";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoMantenimiento"/>
    ///</summary>
    public const string EquipoMantenimiento = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoMantenimiento";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefeMantenimiento"/>
    ///</summary>
    public const string JefeMantenimiento = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefeMantenimiento";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoMantenimientoConExperiencia"/>
    ///</summary>
    public const string EquipoMantenimientoConExperiencia = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoMantenimientoConExperiencia";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoMantenimientoSinExperiencia"/>
    ///</summary>
    public const string EquipoMantenimientoSinExperiencia = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoMantenimientoSinExperiencia";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoServicio"/>
    ///</summary>
    public const string EquipoServicio = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoServicio";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubjefaServicio"/>
    ///</summary>
    public const string SubjefaServicio = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubjefaServicio";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefaServicio"/>
    ///</summary>
    public const string JefaServicio = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefaServicio";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoServicioConExperiencia"/>
    ///</summary>
    public const string EquipoServicioConExperiencia = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoServicioConExperiencia";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoServicioSinExperiencia"/>
    ///</summary>
    public const string EquipoServicioSinExperiencia = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoServicioSinExperiencia";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#ProyectoA"/>
    ///</summary>
    public const string ProyectoA = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#ProyectoA";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#ProyectoB"/>
    ///</summary>
    public const string ProyectoB = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#ProyectoB";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Camila"/>
    ///</summary>
    public const string Camila = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Camila";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Carlos"/>
    ///</summary>
    public const string Carlos = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Carlos";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoVerdeNoExperimentado"/>
    ///</summary>
    public const string EquipoVerdeNoExperimentado = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoVerdeNoExperimentado";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Celeste"/>
    ///</summary>
    public const string Celeste = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Celeste";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Daniela"/>
    ///</summary>
    public const string Daniela = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Daniela";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoAzulNoExperimentado"/>
    ///</summary>
    public const string EquipoAzulNoExperimentado = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoAzulNoExperimentado";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Dante"/>
    ///</summary>
    public const string Dante = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Dante";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Dario"/>
    ///</summary>
    public const string Dario = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Dario";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefeDeMantenimientoEquipoNoExperimentado"/>
    ///</summary>
    public const string JefeDeMantenimientoEquipoNoExperimentado = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefeDeMantenimientoEquipoNoExperimentado";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Diego"/>
    ///</summary>
    public const string Diego = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Diego";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#DirectorEquipoRojoExperimentado"/>
    ///</summary>
    public const string DirectorEquipoRojoExperimentado = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#DirectorEquipoRojoExperimentado";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoRojoExperimentado"/>
    ///</summary>
    public const string EquipoRojoExperimentado = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoRojoExperimentado";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubdirectorEquipoRojoExperimentado"/>
    ///</summary>
    public const string SubdirectorEquipoRojoExperimentado = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubdirectorEquipoRojoExperimentado";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#DirectorEquipoRojoNoExperimentado"/>
    ///</summary>
    public const string DirectorEquipoRojoNoExperimentado = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#DirectorEquipoRojoNoExperimentado";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoRojoNoExperimentado"/>
    ///</summary>
    public const string EquipoRojoNoExperimentado = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoRojoNoExperimentado";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubdirectorEquipoRojoNoExperimentado"/>
    ///</summary>
    public const string SubdirectorEquipoRojoNoExperimentado = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubdirectorEquipoRojoNoExperimentado";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Edgardo"/>
    ///</summary>
    public const string Edgardo = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Edgardo";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoAzulExperimentado"/>
    ///</summary>
    public const string EquipoAzulExperimentado = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoAzulExperimentado";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Gladis"/>
    ///</summary>
    public const string Gladis = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Gladis";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefaDeServicioEquipoExperimentado"/>
    ///</summary>
    public const string JefaDeServicioEquipoExperimentado = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefaDeServicioEquipoExperimentado";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefaDeServicioEquipoNoExperimentado"/>
    ///</summary>
    public const string JefaDeServicioEquipoNoExperimentado = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefaDeServicioEquipoNoExperimentado";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Proyecto2"/>
    ///</summary>
    public const string Proyecto2 = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Proyecto2";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Rolando"/>
    ///</summary>
    public const string Rolando = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Rolando";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Romina"/>
    ///</summary>
    public const string Romina = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Romina";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Sebastian"/>
    ///</summary>
    public const string Sebastian = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Sebastian";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Valeria"/>
    ///</summary>
    public const string Valeria = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Valeria";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Laura"/>
    ///</summary>
    public const string Laura = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Laura";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Pedro"/>
    ///</summary>
    public const string Pedro = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Pedro";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Proyecto1"/>
    ///</summary>
    public const string Proyecto1 = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Proyecto1";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoVerdeExperimentado"/>
    ///</summary>
    public const string EquipoVerdeExperimentado = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#EquipoVerdeExperimentado";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefeDeMantenimientoEquipoExperimentado"/>
    ///</summary>
    public const string JefeDeMantenimientoEquipoExperimentado = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#JefeDeMantenimientoEquipoExperimentado";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Nicolas"/>
    ///</summary>
    public const string Nicolas = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Nicolas";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Marcelo"/>
    ///</summary>
    public const string Marcelo = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Marcelo";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Matias"/>
    ///</summary>
    public const string Matias = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Matias";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Fabiana"/>
    ///</summary>
    public const string Fabiana = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Fabiana";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubjefaDeServicioEquipoExperimentado"/>
    ///</summary>
    public const string SubjefaDeServicioEquipoExperimentado = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubjefaDeServicioEquipoExperimentado";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Gisela"/>
    ///</summary>
    public const string Gisela = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Gisela";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Jorge"/>
    ///</summary>
    public const string Jorge = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Jorge";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Juan"/>
    ///</summary>
    public const string Juan = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Juan";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Mariel"/>
    ///</summary>
    public const string Mariel = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Mariel";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubjefaDeServicioEquipoNoExperimentado"/>
    ///</summary>
    public const string SubjefaDeServicioEquipoNoExperimentado = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#SubjefaDeServicioEquipoNoExperimentado";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Maximiliano"/>
    ///</summary>
    public const string Maximiliano = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Maximiliano";

    ///<summary>
    ///
    ///<see cref="http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Vanina"/>
    ///</summary>
    public const string Vanina = "http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#Vanina";

    ///<summary>
    ///
    ///<see cref="urn:swrl#x"/>
    ///</summary>
    public const string x = "urn:swrl#x";

    ///<summary>
    ///
    ///<see cref="urn:swrl#y"/>
    ///</summary>
    public const string y = "urn:swrl#y";

    ///<summary>
    ///
    ///<see cref="urn:swrl#z"/>
    ///</summary>
    public const string z = "urn:swrl#z";

    ///<summary>
    ///
    ///<see cref="urn:swrl#w"/>
    ///</summary>
    public const string w = "urn:swrl#w";

    ///<summary>
    ///
    ///<see cref="urn:swrl#e"/>
    ///</summary>
    public const string e = "urn:swrl#e";

    ///<summary>
    ///
    ///<see cref="urn:swrl#h"/>
    ///</summary>
    public const string h = "urn:swrl#h";

    ///<summary>
    ///
    ///<see cref="urn:swrl#b"/>
    ///</summary>
    public const string b = "urn:swrl#b";

    ///<summary>
    ///
    ///<see cref="urn:swrl#p"/>
    ///</summary>
    public const string p = "urn:swrl#p";

    ///<summary>
    ///
    ///<see cref="urn:swrl#s"/>
    ///</summary>
    public const string s = "urn:swrl#s";
}
}