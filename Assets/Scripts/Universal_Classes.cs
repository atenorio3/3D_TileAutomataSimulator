using System.Collections;
using System.Collections.Generic;
using System;

namespace UniversalClasses
{

     public class TA_System
     {
          // Note: The simulator will only accept deterministic transition rules. (A bond will only have 1 associated transition rule with it: Ex. [A,B] -> [A,D] only.)
          // Dictionaries of states
          private Dictionary<string, string> allStates;
          private Dictionary<string, string> initialStates;
          private Dictionary<string, string> seedStates;
          // Dictionaries of rules
          private Dictionary<Tuple<string, string>, Tuple<int, char>> xAffinities;
          private Dictionary<Tuple<string, string>, Tuple<string, string, char>> xTransitions;
          private Dictionary<Tuple<string, string>, Tuple<int, char>> yAffinities;
          private Dictionary<Tuple<string, string>, Tuple<string, string, char>> yTransitions;
          private Dictionary<Tuple<string, string>, Tuple<int, char>> zAffinities;
          private Dictionary<Tuple<string, string>, Tuple<string, string, char>> zTransitions;

          // Constructors
          public TA_System()
          {
               allStates = new Dictionary<string, string>();
               initialStates = new Dictionary<string, string>();
               seedStates = new Dictionary<string, string>();
               xAffinities = new Dictionary<Tuple<string, string>, Tuple<int, char>>();
               xTransitions = new Dictionary<Tuple<string, string>, Tuple<string, string, char>>();
               yAffinities = new Dictionary<Tuple<string, string>, Tuple<int, char>>();
               yTransitions = new Dictionary<Tuple<string, string>, Tuple<string, string, char>>();
               zAffinities = new Dictionary<Tuple<string, string>, Tuple<int, char>>();
               zTransitions = new Dictionary<Tuple<string, string>, Tuple<string, string, char>>();
     }
          public TA_System(Dictionary<string, string> inputAll, Dictionary<string, string> inputInitial, Dictionary<string, string> inputSeed, 
               Dictionary<Tuple<string, string>,Tuple<int, char>> xAffinityInput, Dictionary<Tuple<string, string>, Tuple<string, string, char>> xTransitionInput,
               Dictionary<Tuple<string, string>, Tuple<int, char>> yAffinityInput, Dictionary<Tuple<string, string>, Tuple<string, string, char>> yTransitionInput,
               Dictionary<Tuple<string, string>, Tuple<int, char>> zAffinityInput, Dictionary<Tuple<string, string>, Tuple<string, string, char>> zTransitionInput)
          {
               allStates = inputAll;
               initialStates = inputInitial;
               seedStates = inputSeed;
               xAffinities = xAffinityInput;
               xTransitions = xTransitionInput;
               yAffinities = yAffinityInput;
               yTransitions = yTransitionInput;
               zAffinities = zAffinityInput;
               zTransitions = zTransitionInput;
          }
          // Getters
          public Dictionary<string, string> returnAllStates()
          {
               return allStates;
          }
          public Dictionary<string, string> returnInitialStates()
          {
               return initialStates;
          }
          public Dictionary<string, string> returnSeedStates()
          {
               return seedStates;
          }
          public Dictionary<Tuple<string, string>, Tuple<int, char>> returnXAffinities()
          {
               return xAffinities;
          }
          public Dictionary<Tuple<string, string>, Tuple<string, string, char>> returnXTransitions()
          {
               return xTransitions;
          }
          public Dictionary<Tuple<string, string>, Tuple<int, char>> returnYAffinities()
          {
               return yAffinities;
          }
          public Dictionary<Tuple<string, string>, Tuple<string, string, char>> returnYTransitions()
          {
               return yTransitions;
          }
          public Dictionary<Tuple<string, string>, Tuple<int, char>> returnZAffinities()
          {
               return zAffinities;
          }
          public Dictionary<Tuple<string, string>, Tuple<string, string, char>> returnZTransitions()
          {
               return zTransitions;
          }
          // Adders
          public void addAllState(string label, string color)
          {
               allStates.Add(label, color);
          }
          public void addInitialState(string label, string color)
          {
               initialStates.Add(label, color);
          }
          public void addSeedState(string label, string color)
          {
               seedStates.Add(label, color);
          }
          public void addXAffinity(string label1, string label2, int strength)
          {
               xAffinities.Add(Tuple.Create(label1, label2), Tuple.Create(strength, 'x'));
          }
          public void addXTransition(string label1, string label2, string label1Final, string label2Final)
          {
               xTransitions.Add(Tuple.Create(label1, label2), Tuple.Create(label1Final, label2Final, 'x'));
          }
          public void addYAffinity(string label1, string label2, int strength)
          {
               yAffinities.Add(Tuple.Create(label1, label2), Tuple.Create(strength, 'y'));
          }
          public void addYTransition(string label1, string label2, string label1Final, string label2Final)
          {
               yTransitions.Add(Tuple.Create(label1, label2), Tuple.Create(label1Final, label2Final, 'y'));
          }
          public void addZAffinity(string label1, string label2, int strength)
          {
               zAffinities.Add(Tuple.Create(label1, label2), Tuple.Create(strength, 'z'));
          }
          public void addZTransition(string label1, string label2, string label1Final, string label2Final)
          {
               zTransitions.Add(Tuple.Create(label1, label2), Tuple.Create(label1Final, label2Final, 'z'));
          }

          // Utility

     }
}