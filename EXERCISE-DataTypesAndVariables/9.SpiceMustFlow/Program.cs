/* silly template */

// initialize inputs defined by problem



// parse inputs from console

//Console.Write("└─ Starting source yield: ");
int sourceStartingYield = int .Parse(Console.ReadLine());


int currentYield = sourceStartingYield;
int spiceExtracted = 0;
int days = 0;
int consumedSpice = 26;

// preform needed operation and print out result

while (currentYield >= 100)
{
    spiceExtracted += currentYield;
    spiceExtracted -= consumedSpice;
    currentYield -= 10;
    days++;

    //Console.WriteLine($"├─ Day {days} ── ─ ─ ─\n" +
    //                  $"│ ┌───────────────── ─ ─ ─\n" +
    //                  $"│ │ Current Yield: {currentYield}\n" +
    //                  $"│ │ Extracted Spice: {spiceExtracted}\n" +
    //                  $"│ └───────────────── ─ ─ ─\n" +
    //                  $"│");
}

spiceExtracted -= consumedSpice;

//Console.WriteLine($"├─ Abandon Source! ── ─ ─ ─\n" +
//                  $"│ ┌───────────────── ─ ─ ─\n" +
//                  $"│ │ Days spent: {days}\n" +
//                  $"│ │ Extracted Spice: {spiceExtracted}\n" +
//                  $"│ └───────────────── ─ ─ ─\n" +
//                  $"│");
Console.WriteLine(days);
Console.WriteLine(spiceExtracted);

Environment.Exit(0);