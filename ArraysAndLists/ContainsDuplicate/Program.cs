// Given an integer array 'nums', returns true if any value appears at least twice int he array, and return false if every elements is distinct 

/*
Example 1:

Input : nums = [1,2,3,1]
Output : true

Example 2:

Input : nums = [1,2,3,4]
output: false

*/

int[] myArray = [1, 2, 3, 4, 5, 3, 2];

bool Solution1()
{
  HashSet<int> mySet = []; // Yeni bir yer açmamız O(n) olacktır.

  for (int i = 0; i < myArray.Length; i++) // Bütün diziyi dolaşmak O(n)
  {
    if (mySet.Contains(myArray[i])) return true;
    mySet.Add(myArray[i]);
  }
  return false;
}

Console.WriteLine(Solution1());


bool Solution2()
{
  return myArray.Length != new HashSet<int>(myArray).Count; // Yeni bir yer açmamız O(n) olacktır. Bütün diziyi dolaşmak O(n)
}

Console.WriteLine(Solution2());

/*
Problem çözüm yolları :
1- Bruth Force
  Her bir indeksdeki eleman bütün indexleri dolaşacaktır. Buda Time complexity olarak bize O(n^2) ve Space complexity ise yeni bir yer oluşturamdan bütün elemanları o dizi içerisinde gezdiğimiz için O(1) olacaktır.

2- Pointer
  Dizi sıralıysa bir ilk baştaki 2 değere bir pointer(değişken) atarak bunları her defasında bir sağ götürülür bunlar yan yana olacağı için, dizili olacağı için, aynıysa bir değer yanyana gelecektir. Bunu yaparak bir diziiyi n defa dolşaırız. Bu datime complexity i O(n) yapar. Yeni bir yer açmadığımız için aynı dizi içinde dolaştığımızdan dolayı Space complecity de O(1) yapar.

3- Sort + Pointer
  Eğer dizi sıralı değilse bunu biz sıralarız. Bunun en ideal time complexity ise O(nlogn) dir. O(1) olacaktır. Eğer bunlar içinde space complexty O(n) çıkarırsak o zaman time complexity de O(n) düşerebilriz. Bunun çözümü de aşağıdadır.
*/

