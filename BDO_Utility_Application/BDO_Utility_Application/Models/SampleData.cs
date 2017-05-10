using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace BDO_Utility_Application.Models
{
    public class SampleData : DropCreateDatabaseAlways<BdoContext>
    {
        protected override void Seed(BdoContext context)
        {
            base.Seed(context);

            //Sample Data

            //Node Types
            List<NodeType> NodeTypes = new List<NodeType>
            {
                new NodeType("Node"),
                new NodeType("Town"),
                new NodeType("City"),
                new NodeType("Gateway"),
                new NodeType("Trade"),
                new NodeType("Danger Zone")
            };

            NodeTypes.ForEach(n => context.NodeTypes.Add(n));
            context.SaveChanges();


            //Nodes
            List<Node> Nodes = new List<Node>
            {
                new Node("Epheria Ridge"),
                new Node("Elder’s Bridge"),
                new Node("Foot of Thermian Mountain"),
                new Node("Mask Owl Forest"),
                new Node("Florin Gateway"),
                new Node("Thermian Cliff"),
                new Node("Wale Farm"),
                new Node("Olvia"),
                new Node("Olvia Coast"),
                new Node("Wolf Hills"),
                new Node("Balenos River Mouth"),
                new Node("Western Gateway"),
                new Node("Western Guard Camp"),
                new Node("Forest of Seclusion"),
                new Node("Bandit’s Den Byway"),
                new Node("Toscani Farm"),
                new Node("Imp Cave"),
                new Node("Altar of Aegis"),
                new Node("Coastal Cliff"),
                new Node("Coastal Cave"),
                new Node("Loggia Farm"),
                new Node("Marino Farm"),
                new Node("Bartali Farm"),
                new Node("Velia"),
                new Node("Cron Castle"),
                new Node("Cron Castle Site"),
                new Node("Ehwaz Hill"),
                new Node("Finto Farm"),
                new Node("Forest of Plunder"),
                new Node("Goblin Cave"),
                new Node("iids"),
                new Node("Heidel Pass"),
                new Node("Northen Heidel Quarry"),
                new Node("Alejandro Farm"),
                new Node("Lynch Farm Ruins"),
                new Node("Lynch Ranch"),
                new Node("Northern Plains of Serendia"),
                new Node("Biraghi Den"),
                new Node("Eastern Border"),
                new Node("Moretti Plantation"),
                new Node("Northern Cienaga"),
                new Node("Eastern Gateway"),
                new Node("Castle Ruins"),
                new Node("Costa Farm"),
                new Node("Central Guard Camp"),
                new Node("Glish Ruins"),
                new Node("Southern Guard Camp"),
                new Node("Serendia Shrine"),
                new Node("Northwestern Gateway"),
                new Node("Glish Swamp"),
                new Node("Glish"),
                new Node("Southern Cienaga"),
                new Node("Southwestern Gateway"),
                new Node("Bloody Monastery"),
                new Node("Bradie Fortress"),
                new Node ("Orc Camp"),
                new Node ("Watch Tower"),
                new Node ("Southern Neutral Zone"),
                new Node ("Epheria Sentry Post"),
                new Node ("Epheria Valley"),
                new Node ("Quint Hill"),
                new Node ("Isolated Sentry Post"),
                new Node ("Cohen Farm"),
                new Node ("Abandoned Land"),
                new Node ("Elder’s Bridge Post"),
                new Node ("Anti-Troll Fortification"),
                new Node ("Contaminated Farm"),
                new Node ("Bree Tree Ruins"),
                new Node ("Bernianto Farm"),
                new Node ("Northern Wheat Plantation"),
                new Node ("Dias Farm"),
                new Node ("Florin"),
                new Node ("Caphras Cave"),
                new Node ("Khuruto Cave"),
                new Node ("Old Dandelion"),
                new Node ("Karanda Ridge"),
                new Node ("Delphe Outpost"),
                new Node ("Delphe Knight’s Castle"),
                new Node ("Falres Dirt Farm"),
                new Node ("Oberen Farm"),
                new Node ("Bain Farmland"),
                new Node ("Marni Farm Ruins"),
                new Node ("Beacon Entrance Post"),
                new Node ("Trina Beacon Mounds"),
                new Node ("Trina Fort"),
                new Node ("Saunil Camp"),
                new Node ("Saunil Battlefield"),
                new Node ("Marni Cave Path"),
                new Node ("Marni’s Lab"),
                new Node ("Glutoni Cave"),
                new Node ("Oze Pass"),
                new Node ("Oze’s House"),
                new Node ("Abandoned Quarry"),
                new Node ("Quarry Byway"),
                new Node ("Keplan Quarry"),
                new Node ("Keplan"),
                new Node ("Keplan Vicinity"),
                new Node ("Keplan Hill"),
                new Node ("Tarte Rock Fork"),
                new Node ("Dane Canyon"),
                new Node ("Abandoned Quarry"),
                new Node ("Gianin Farm"),
                new Node ("Closed Western Gateway"),
                new Node ("Primal Giant Post"),
                new Node ("Hexe Stone Wall"),
                new Node ("Marie Cave"),
                new Node ("Witch’s Chapel"),
                new Node ("Hexe Sanctuary"),
                new Node ("Gabino Farm"),
                new Node ("North Kaia Mountaintop"),
                new Node ("Phoniel’s Cabin"),
                new Node ("Phoniel’s Cabin Entrance"),
                new Node ("Behr Riverhead"),
                new Node ("Behr Downstream"),
                new Node ("Rhua Tree Stub"),
                new Node ("Behr"),
                new Node ("Longleaf Tree Forest"),
                new Node ("Crioville"),
                new Node ("Longleaf Tree Sentry Post"),
                new Node ("Trent"),
                new Node ("Lumberjack’s Rest Area"),
                new Node ("Abandoned Monastery"),
                new Node ("Treant Forest"),
                new Node ("Tobare’s Cabin"),
                new Node ("Mansha Forest"),
                new Node ("Calpheon Castle Western Front"),
                new Node ("Catfishman Camp"),
                new Node ("Lake Kaia"),
                new Node ("Calpheon Castle Site"),
                new Node ("Calpheon Castle"),
                new Node ("North Kaia Ferry"),
                new Node ("South Kaia ferry"),
                new Node ("Rhutum Sentry Post"),
                new Node ("Rhutum Outstation"),
                new Node ("Serca Island"),
                new Node ("Randis Island"),
                new Node ("Baeza Island"),
                new Node ("Modric Island"),
                new Node ("Theonil Island"),
                new Node ("Teyamal Island"),
                new Node ("Rameda Island"),
                new Node ("Ginburrey Island"),
                new Node ("Daton Island"),
                new Node ("Netnume Island"),
                new Node ("Oben Island"),
                new Node ("Dunde Island"),
                new Node ("Eberdeen Island"),
                new Node ("Albresser Island"),
                new Node ("Barater Island")
                

            };

            Nodes.ForEach(n => context.Nodes.Add(n));
            context.SaveChanges();

            //Occupations
            List<Occupation> Occupations = new List<Occupation>
            {
                new Occupation("Node Manager"),
                new Occupation("Occupation Name 2")
            };

            Occupations.ForEach(n => context.Occupations.Add(n));
            context.SaveChanges();

            //Persons
            List<Person> Persons = new List<Person>
            {
                new Person("Person Name 1"),
                new Person("Person Name 2")
            };

            Persons.ForEach(n => context.Persons.Add(n));
            context.SaveChanges();

            //ProcessTypes
            List<ProcessType> ProcessTypes = new List<ProcessType>
            {
                new ProcessType("ProcessType Name 1"),
                new ProcessType("ProcessType Name 2")
            };

            ProcessTypes.ForEach(n => context.ProcessTypes.Add(n));
            context.SaveChanges();

            //RawMaterials
            List<RawMaterial> RawMaterials = new List<RawMaterial>
            {
                new RawMaterial("RawMaterial Name 1"),
                new RawMaterial("RawMaterial Name 2")
            };

            RawMaterials.ForEach(n => context.RawMaterials.Add(n));
            context.SaveChanges();

            //Territories
            List<Territory> Territories = new List<Territory>
            {
                new Territory("Balanos - West"),
                new Territory("Balanos - East"),
                new Territory("Serendia"),
                new Territory("Calpheon - North"),
                new Territory("Calpheon – Southeast"),
                new Territory("Calpheon - Southwest"),
                new Territory("Oceanic Nodes")
            };

            Territories.ForEach(n => context.Territories.Add(n));
            context.SaveChanges();

            //Tools
            List<Tool> Tools = new List<Tool>
            {
                new Tool("Tool Name 1"),
                new Tool("Tool Name 2")
            };

            Tools.ForEach(n => context.Tools.Add(n));
            context.SaveChanges();
        }
    }
}