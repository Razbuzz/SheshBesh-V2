using Accessibility;
using System.Drawing; // Make sure to include this namespace for Color and Point
using System.Windows.Forms;

namespace gameee
{
    public partial class Form1 : Form
    {
        private readonly int TOP_Y = 50;
        private readonly int BUTTON_Y = 715;
        private readonly int PIECE_HEIGHT = 40;
        private readonly int PIECE_WIDTH = 40;
        private readonly int[] ALL_X = new int[12];
        private readonly int MIDDLE_X = 480;
        private Button[] buttons = new Button[30];
        List<int>[] board = BoardUtils.createBoard();

        public Form1()
        {
            InitializeComponent();
            ALL_X[0] = 58;
            for (int i = 0; i < 6; i++)
            {
                ALL_X[i] = ALL_X[0] + i * 70;
            }
            ALL_X[6] = 560;
            for (int i = 0; i < 6; i++)
            {
                ALL_X[i + 6] = ALL_X[6] + i * 70;
            }
            int idx = 0;

            for (int i = 0; i < board.Length; i++)
            {
                int height = board[i].Count;
                if (height == 0)
                {
                    continue;
                }
                Color color1;
                if (board[i][0] == 0)
                {
                    color1 = Color.Black;
                }
                else
                {
                    color1 = Color.White;
                }
                Size pieceSize = new Size(PIECE_WIDTH, PIECE_HEIGHT);
                for (int j = 0; j < height; j++)
                {
                    buttons[idx] = new Button();
                    buttons[idx].Size = pieceSize;
                    buttons[idx].Location = getLocatian(i, j);
                    buttons[idx].BackColor = color1;
                    buttons[idx].Enabled = (j == height - 1);
                    buttons[idx].Visible = true;
                    this.Controls.Add(buttons[idx]); 
                    idx++;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Point getLocatian(int index, int height)
        {
            if (index < 12)
            {
                return new Point(ALL_X[index % 12], TOP_Y + height * PIECE_HEIGHT);
            }
            return new Point(ALL_X[index % 12], BUTTON_Y - height * PIECE_HEIGHT);
        }
    }
}
