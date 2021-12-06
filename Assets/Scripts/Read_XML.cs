using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using System;
using UnityEngine;
using UniversalClasses;

public class Read_XML : MonoBehaviour
{
     public static TA_System loadedSystem;
     public void LoadSystem()
     {
          // Access the target XML file universally.
          string baseDirectory = Directory.GetCurrentDirectory();
          string targetDirectory = Path.Combine(baseDirectory, @"Assets\XML Files");
          string fileName = Path.Combine(targetDirectory, @"test.xml");

          // Records every state/rule in the system.
          loadedSystem = new TA_System();

          XmlDocument Xdoc = new XmlDocument();
          Xdoc.Load(fileName);
          XmlNode root = Xdoc.DocumentElement; // Records root of XML file.

          // Records every branch within System (root) of XML.
          XmlNode allStates = root.SelectSingleNode("AllStates");
          XmlNode initialStates = root.SelectSingleNode("InitialStates");
          XmlNode seedStates = root.SelectSingleNode("SeedStates");
          XmlNode xAffinities = root.SelectSingleNode("X-Affinities");
          XmlNode xTransitions = root.SelectSingleNode("X-Transitions");
          XmlNode yAffinities = root.SelectSingleNode("Y-Affinities");
          XmlNode yTransitions = root.SelectSingleNode("Y-Transitions");
          XmlNode zAffinities = root.SelectSingleNode("Z-Affinities");
          XmlNode zTransitions = root.SelectSingleNode("Z-Transitions");

          // Read through allStates and record each state to loadSystem's allStates Dictionary.
          var currentStateDictionary = loadedSystem.returnAllStates();
          foreach(XmlNode node in allStates)
          {
               string label = node.Attributes["Label"].Value;
               string color = node.Attributes["Color"].Value;

               if (!currentStateDictionary.ContainsKey(label)) // If the new entry won't make a duplicate...
               {
                    loadedSystem.addAllState(label, color); // Add the new entry into the current dictionary.
               }
          }

          // For loadSystem's initialStates:
          currentStateDictionary = loadedSystem.returnInitialStates();
          foreach (XmlNode node in initialStates)
          {
               string label = node.Attributes["Label"].Value;
               string color = node.Attributes["Color"].Value;

               if (!currentStateDictionary.ContainsKey(label))
               {
                    loadedSystem.addInitialState(label, color);
               }
          }

          // For loadSystem's seedStates:
          currentStateDictionary = loadedSystem.returnSeedStates();
          foreach(XmlNode node in seedStates)
          {
               string label = node.Attributes["Label"].Value;
               string color = node.Attributes["Color"].Value;

               if (!currentStateDictionary.ContainsKey(label))
               {
                    loadedSystem.addSeedState(label, color);
               }
          }

          // Now for rules...
          // For loadSystem's xAffinities:
          var currentAffinityDictionary = loadedSystem.returnXAffinities();
          foreach(XmlNode node in xAffinities)
          {
               string label1 = node.Attributes["Label1"].Value;
               string label2 = node.Attributes["Label2"].Value;
               int strength = Int32.Parse(node.Attributes["Strength"].Value);

               if (!currentAffinityDictionary.ContainsKey(Tuple.Create(label1, label2)))
               {
                    loadedSystem.addXAffinity(label1, label2, strength);
               }
          }

          // loadSystem's xTransitions:
          var currentTransitionDictionary = loadedSystem.returnXTransitions();
          foreach(XmlNode node in xTransitions)
          {
               string label1 = node.Attributes["Label1"].Value;
               string label2 = node.Attributes["Label2"].Value;
               string label1Final = node.Attributes["Label1Final"].Value;
               string label2Final = node.Attributes["Label2Final"].Value;

               if(!currentTransitionDictionary.ContainsKey(Tuple.Create(label1, label2)))
               {
                    loadedSystem.addXTransition(label1, label2, label1Final, label2Final);
               }
          }

          // yAffinities:
          currentAffinityDictionary = loadedSystem.returnYAffinities();
          foreach (XmlNode node in yAffinities)
          {
               string label1 = node.Attributes["Label1"].Value;
               string label2 = node.Attributes["Label2"].Value;
               int strength = Int32.Parse(node.Attributes["Strength"].Value);

               if (!currentAffinityDictionary.ContainsKey(Tuple.Create(label1, label2)))
               {
                    loadedSystem.addYAffinity(label1, label2, strength);
               }
          }

          // yTransitions:
          currentTransitionDictionary = loadedSystem.returnYTransitions();
          foreach (XmlNode node in yTransitions)
          {
               string label1 = node.Attributes["Label1"].Value;
               string label2 = node.Attributes["Label2"].Value;
               string label1Final = node.Attributes["Label1Final"].Value;
               string label2Final = node.Attributes["Label2Final"].Value;

               if (!currentTransitionDictionary.ContainsKey(Tuple.Create(label1, label2)))
               {
                    loadedSystem.addYTransition(label1, label2, label1Final, label2Final);
               }
          }

          // zAffinities:
          currentAffinityDictionary = loadedSystem.returnZAffinities();
          foreach (XmlNode node in zAffinities)
          {
               string label1 = node.Attributes["Label1"].Value;
               string label2 = node.Attributes["Label2"].Value;
               int strength = Int32.Parse(node.Attributes["Strength"].Value);

               if (!currentAffinityDictionary.ContainsKey(Tuple.Create(label1, label2)))
               {
                    loadedSystem.addZAffinity(label1, label2, strength);
               }
          }

          // zTransitions:
          currentTransitionDictionary = loadedSystem.returnZTransitions();
          foreach (XmlNode node in zTransitions)
          {
               string label1 = node.Attributes["Label1"].Value;
               string label2 = node.Attributes["Label2"].Value;
               string label1Final = node.Attributes["Label1Final"].Value;
               string label2Final = node.Attributes["Label2Final"].Value;

               if (!currentTransitionDictionary.ContainsKey(Tuple.Create(label1, label2)))
               {
                    loadedSystem.addZTransition(label1, label2, label1Final, label2Final);
               }
          }

          // Display allStates:
          Debug.Log("All states recorded in AllStates:");
          foreach(KeyValuePair<string, string> state in loadedSystem.returnAllStates())
          {
               Debug.Log(string.Format("Label = {0}; Color = {1}", state.Key, state.Value));
          }
     }
}
