using System;

class Program
{
    static void Main()
    {
        // Create a jagged array to store student scores
        int[][] studentScores = new int[][]
        {
            new int[] {85, 92, 78},
            new int[] {90, 87, 93, 89},
            new int[] {76, 88}
        };

        // Print scores of each student using nested loops
        for (int i = 0; i < studentScores.Length; i++)
        {
            Console.Write($"Student {i + 1} Scores: ");
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                Console.Write($"{studentScores[i][j]} ");
            }
            Console.WriteLine();
        }

        // Calculate and print average score for each student
        for (int i = 0; i < studentScores.Length; i++)
        {
            double averageScore = CalculateAverage(studentScores[i]);
            Console.WriteLine($"Average score for Student {i + 1}: {averageScore:F2}");
        }

        // Calculate and print average score for all students combined
        double overallAverage = CalculateAverage(studentScores);
        Console.WriteLine($"Overall Average Score: {overallAverage:F2}");
    }

    // Helper method to calculate average of an array of scores
    static double CalculateAverage(int[] scores)
    {
        double sum = 0;
        foreach (int score in scores)
        {
            sum += score;
        }
        return sum / scores.Length;
    }

    // Overloaded method to calculate average of a jagged array of scores
    static double CalculateAverage(int[][] scores)
    {
        double sum = 0;
        int count = 0;
        foreach (int[] studentScores in scores)
        {
            foreach (int score in studentScores)
            {
                sum += score;
                count++;
            }
        }
        return sum / count;
    }
}
