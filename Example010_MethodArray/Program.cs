int [] array = {15,26,34,38,57,699,57,38};

int n = array.Length;
int find = 38;

int index = 0;

while (index<n)
{
  if(array[index] == find)
  {
   Console.WriteLine(index);  
   break;
  }
  //index = index+1;
  index++; 
}

