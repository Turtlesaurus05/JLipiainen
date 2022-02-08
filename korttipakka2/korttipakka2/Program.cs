// See https://aka.ms/new-console-template for more information
        public void LoadModule(object sender, System.EventArgs e)

{

    // declare local variables.   

    int stopvar, b, c, d, setmark;

    string card1, card2, currdir;



    // get current working directory of game installation  

    currdir = Directory.GetCurrentDirectory();

    currdir = currdir.Substring(0, currdir.Length - 9);



    // set boundaries of form.  

    this.SetBounds(1, 1, 1800, 1800);

    // set the start position of the form to the center of the screen.  

    this.StartPosition = FormStartPosition.CenterScreen;



    // assign sequential playing card designators to ‘cardvault’  

    // character array.  

    cardvault[0] = "2C";

    cardvault[1] = "2S";

    cardvault[2] = "2H";

    cardvault[3] = "2D";

    cardvault[4] = "3C";

    cardvault[5] = "3S";

    cardvault[6] = "3H";

    cardvault[7] = "3D";

    cardvault[8] = "4C";

    cardvault[9] = "4S";

    cardvault[10] = "4H";

    cardvault[11] = "4D";

    cardvault[12] = "5C";

    cardvault[13] = "5S";

    cardvault[14] = "5H";

    cardvault[15] = "5D";

    cardvault[16] = "6C";

    cardvault[17] = "6S";

    cardvault[18] = "6H";

    cardvault[19] = "6D";

    cardvault[20] = "7C";

    cardvault[21] = "7S";

    cardvault[22] = "7H";

    cardvault[23] = "7D";

    cardvault[24] = "8C";

    cardvault[25] = "8S";

    cardvault[26] = "8H";

    cardvault[27] = "8D";

    cardvault[28] = "9C";

    cardvault[29] = "9S";

    cardvault[30] = "9H";

    cardvault[31] = "9D";

    cardvault[32] = "10C";

    cardvault[33] = "10S";

    cardvault[34] = "10H";

    cardvault[35] = "10D";

    cardvault[36] = "JC";

    cardvault[37] = "JS";

    cardvault[38] = "JH";

    cardvault[39] = "JD";

    cardvault[40] = "QC";

    cardvault[41] = "QS";

    cardvault[42] = "QH";

    cardvault[43] = "QD";

    cardvault[44] = "KC";

    cardvault[45] = "KS";

    cardvault[46] = "KH";

    cardvault[47] = "KD";

    cardvault[48] = "AC";

    cardvault[49] = "AS";

    cardvault[50] = "AH";

    cardvault[51] = "AD";

    // initialize the character array ‘shufflevault’ that  

    // will hold the shuffled card order.  

    for (a = 0; a < 52; a++) shufflevault[a] = " ";

    // create object for random number generator for  

    // a specified number range.  

    Random RandomNumber = new Random();

    // using the above object, generate a random number  

    // between 1 and 51.  

    setmark = RandomNumber.Next(1, 51);

}