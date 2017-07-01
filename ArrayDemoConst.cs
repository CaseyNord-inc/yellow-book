using System;

cilelass ArrayDemo
{
    public static void Main()
    {
        const int SCORE_SIZE = 1000
        int [] scores = new int [SCORE_SIZE];
        for (int i=0; i<SCORE_SIZE; i=i+1)
        {
            scores [i] readInt ("Score: ", 0, 1000);
        }
    }
}