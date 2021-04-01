using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace Chapter8_Program7
{
    class Game
    {

        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;

        public Game(string playerName, IEnumerable<string> computerNames, TextBox textProgress)
        {
            Random random = new Random();
            textBoxOnForm = textProgress;
            players = new List<Player>
            {
                new Player(playerName, random, textProgress)
            };

            foreach (string player in computerNames)
            {
                players.Add(new Player(player, random, textProgress));
            }

            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        private void Deal()
        {
            stock.Shuffle();

            for (int i = 0; i < 5; i++)
            {
                foreach (Player player in players)
                {
                    player.TakeCard(stock.Deal());
                }
            }

            foreach (Player player in players)
            {
                PullOutBooks(player);
            }
        }

        public IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }

        public string DescribeBooks()
        {
            string description = "";
            foreach(Values value in books.Keys)
            {
                description += $"{books[value].Name} has a book of {Card.Plural(value)}\r\n";
            }

            return description;
        }

        public string DescribePlayerHands()
        {
            string description = "";

            for (int i = 0; i < players.Count; i++)
            {
                description += $"{players[i].Name} has {players[i].CardCount}";

                if (players[i].CardCount == 1)
                {
                    description += $" card. {Environment.NewLine}";
                }
                else
                {
                    description += $" cards. {Environment.NewLine}";
                }
            }

            description += $"The stock has {stock.Count} cards left.";
            return description;
        }

        public bool PlayOneRound(int cardIndex)
        {
            Values cardToAskFor = players[0].Peek(cardIndex).Value;
            for (int playerIndex = 0; playerIndex < players.Count; playerIndex++)
            {
                Player player = players[playerIndex];

                if (playerIndex == 0)
                {
                    player.AskForACard(players, playerIndex, stock, cardToAskFor);
                }
                else
                {
                    player.AskForACard(players, playerIndex, stock);
                }

                if (PullOutBooks(player))
                {
                    textBoxOnForm.Text += $"{player.Name} drew a new hand {Environment.NewLine}";

                    int card = 1;
                    while (card <= 5 && stock.Count > 0)
                    {
                        player.TakeCard(stock.Deal());
                        card++;
                    }
                }
            }

            players[0].SortHand();
        
            if (stock.Count == 0)
            {
                textBoxOnForm.Text = "The stock is out of cards. Game over!\r\n";
                return true;
            }

            return false;
        }

        public bool PullOutBooks(Player player)
        {
            foreach (Values value in player.PullOutBooks())
            {
                books.Add(value, player);
            }

            return player.CardCount == 0;
        }

        public string GetWinnerName()
        {
            Dictionary<string, int> winners = new Dictionary<string, int>();
         
            foreach (Values value in books.Keys)
            {
                Player player = books[value];

                if (!winners.ContainsKey(player.Name))
                {
                    winners.Add(player.Name, 0);
                }

                winners[player.Name]++;
            }

            int maxBooks = 0;

            foreach(int value in winners.Values)
            {
                if (value > maxBooks)
                {
                    maxBooks = value;
                }
            }

            List<string> absoluteWinners = new List<string>();

            foreach(string key in winners.Keys)
            {
                if (winners[key] == maxBooks)
                {
                    absoluteWinners.Add(key);
                }
            }

            string message ;

            if (absoluteWinners.Count == 1)
            {
                message = $"{absoluteWinners[0]} with {maxBooks} books";
            }
            else
            {
                message = $"A tie between";

                for (int i = 0; i < absoluteWinners.Count; i++)
                {
                    string name = absoluteWinners[i];

                    if (i == 0)
                    {
                        message += $" {name}";
                    }
                    else
                    {
                        message += $" and {name}";
                    }
                }

                message += $" with {maxBooks} books.";
            }

            return message;
        }
    }
}
