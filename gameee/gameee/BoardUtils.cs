using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameee
{
    public static class BoardUtils
    {
        const int BLACK = 0;
        const int WHITE = 1;
        const int WHITE_HOUSE = 0;
        const int BLACK_HOUSE = 23;
        const int BOARD_SIZE = 24;


        public static void addACouple(List<int>[] board, int index, int amount, int player)
        {
            for (int i = 0; i < amount; i++)
            {
                board[index].Add(player);
            }
        }

        public static void setWhitePlayer(List<int>[] board)
        {
            addACouple(board, BLACK_HOUSE, 2, WHITE);

            addACouple(board, 5, 5, WHITE);

            addACouple(board, 7, 3, WHITE);

            addACouple(board, 12, 5, WHITE);

        }

        public static void setBlackPlayer(List<int>[] board)
        {
            addACouple(board, WHITE_HOUSE, 2, BLACK);

            addACouple(board, 18, 5, BLACK);

            addACouple(board, 15, 3, BLACK);

            addACouple(board, 11, 5, BLACK);

        }


        public static List<int>[] createBoard()
        {
            List<int>[] board = new List<int>[BOARD_SIZE];
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                board[i] = new List<int>();
            }

            setBlackPlayer(board);
            setWhitePlayer(board);

            return board;
        }

    }
}
