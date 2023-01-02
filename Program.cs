string [] array = { "abc" , "345678" , "qq", "geek", "brains" , "123" };

string [] result = new string[array.Length];

int num = 0;

for(int n = 0; n < array.Length; n++){

    if (array[n].Length < 4) {

        result[num] = array[n];

        num++;

    } 
}

for(int i = 0; i < num; i++) {

    Console.Write ($"{result[i]} ");

}

