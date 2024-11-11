string lines = File.ReadAllText("input.txt");

string[] numbers = lines.Split(Environment.NewLine);

int[] nums = new int[numbers.Length];

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = int.Parse(numbers[i]);
}


const int S = 2020;

Part1(nums, S);
Part2(nums, S);

void Part2(int[] nums, int s)
{
    int result = 0;
    bool found = false;
    for (int i = 0; !found && i < nums.Length; i++)
        for (int j = i + 1; !found && j < nums.Length; j++)
            for (int k = j + 1; ! found && k < nums.Length; k++)
            if (nums[i] + nums[j] + nums[k] == S)
            {
                result = nums[i] * nums[j] * nums[k];
                found = true;
            }


    Console.WriteLine(result);
}

static void Part1(int[] nums, int S)
{
    int result = 0;
    bool found = false;
    for (int i = 0; !found && i < nums.Length; i++)
        for (int j = i + 1; !found && j < nums.Length; j++)
            if (nums[i] + nums[j] == S)
            {
                result = nums[i] * nums[j];
                found = true;
            }


    Console.WriteLine(result);
}

/*
 * 1 4 7 9 10 (pt ordonare O(n Log n)
 * 
 * */