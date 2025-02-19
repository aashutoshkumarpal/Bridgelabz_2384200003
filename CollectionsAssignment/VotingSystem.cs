using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsAssignment
{
    public class VotingSystem
    {
        private Dictionary<string, int> voteCounts = new Dictionary<string, int>();
        private SortedDictionary<string, int> sortedVotes = new SortedDictionary<string, int>();
        private LinkedList<KeyValuePair<string, int>> voteOrder = new LinkedList<KeyValuePair<string, int>>();

        // Cast a vote
        public void CastVote(string candidate)
        {
            if (voteCounts.ContainsKey(candidate))
            {
                voteCounts[candidate]++;
            }
            else
            {
                voteCounts[candidate] = 1;
            }

            // Update sorted dictionary
            sortedVotes[candidate] = voteCounts[candidate];

            // Maintain vote order (similar to LinkedHashMap)
            voteOrder.AddLast(new KeyValuePair<string, int>(candidate, voteCounts[candidate]));
        }

        // Display votes in order of insertion
        public void DisplayVotesInOrder()
        {
            Console.WriteLine("\nVotes in Order of Voting:");
            foreach (var vote in voteOrder)
            {
                Console.WriteLine($"{vote.Key}: {vote.Value}");
            }
        }

        // Display votes sorted by candidate name
        public void DisplaySortedVotes()
        {
            Console.WriteLine("\nSorted Voting Results:");
            foreach (var kvp in sortedVotes)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        // Display winner(s)
        public void DisplayWinner()
        {
            int maxVotes = voteCounts.Values.Max();
            var winners = voteCounts.Where(x => x.Value == maxVotes).Select(x => x.Key).ToList();

            Console.WriteLine("\nWinner(s):");
            foreach (var winner in winners)
            {
                Console.WriteLine($"{winner} with {maxVotes} votes");
            }
        }

        public static void Main(string[] args)
        {
            VotingSystem votingSystem = new VotingSystem();

            // Casting votes
            votingSystem.CastVote("Alice");
            votingSystem.CastVote("Bob");
            votingSystem.CastVote("Alice");
            votingSystem.CastVote("Charlie");
            votingSystem.CastVote("Bob");
            votingSystem.CastVote("Alice");

            // Display results
            votingSystem.DisplayVotesInOrder();
            votingSystem.DisplaySortedVotes();
            votingSystem.DisplayWinner();
        }
    }
}
