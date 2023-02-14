// use a while loop to pring the cube of the odd numbers from 1 to 25

int x = 1;
while (x <= 25) {
    if (x % 2 == 0) {
        x++;
        continue;
    }


    Console.WriteLine($"{x}^3 is {x} * {x} * {x}");
    x++;
}
Console.WriteLine("Done");