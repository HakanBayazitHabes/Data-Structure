/*
Single Number

    Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

    You must implement a solution with a linear runtime complexity and use only constant extra space.

    Example 1:

        •	Input: nums = [2,2,1]
        •	Output: 1

    Example 2:

        •	Input: nums = [4,1,2,1,2]
        •	Output: 4

    Example 3:

        •	Input: nums = [1]
        •	Output: 1
*/

int SingleNumber()
{
    int[] myArray = [3, 5, 7, 4, 3, 7, 5];

    int result = 0;

    for (int i = 0; i < myArray.Length; i++)
    {
        result = myArray[i] ^ result;
    }

    return result;
}

Console.WriteLine(SingleNumber());

/*
    Yöntem : Bit Manipulation

    Problemin çözümünde bizden 
        Time Complexity : O(n)
        Space Complexity : O(1) istiyor.


     XOR işlemi (^) iki sayının ikili (binary) bitlerini karşılaştırır:
     Aynıysa sonuç 0, farklıysa sonuç 1 olur.
    
     Örnek: 3 ^ 5 hesaplaması
     3: 0011 (Binary)
     5: 0101 (Binary)
     XOR sonucu: 0110 (Binary) = 6 (Decimal)
    
     Adım Adım XOR Hesaplaması:
     Bit Pozisyonu | 3 (0011) | 5 (0101) | XOR Sonucu (0110)
     --------------|----------|----------|-------------------
     3. Bit (MSB)  | 0        | 0        | 0
     2. Bit        | 0        | 1        | 1
     1. Bit        | 1        | 0        | 1
     0. Bit (LSB)  | 1        | 1        | 0
    
     Algoritma: myArray'deki her elemanı XOR ile 'result' üzerinde biriktirir.
     Tekrarlayan sayılar birbirini sıfırlar ve sonuç olarak yalnızca bir kez
     bulunan sayı kalır.

     XOR (^) işlemi özet:
     - İki bit aynıysa sonuç 0 olur.
     - İki bit farklıysa sonuç 1 olur.
     
     Önemli özellikler:
     - a ^ a = 0 (Aynı sayıların XOR'u 0 olur)
     - a ^ 0 = a (Bir sayının 0 ile XOR'u kendisidir)
     - XOR işlemi değiştirme özelliğine sahiptir: (a ^ b) ^ c = a ^ (b ^ c)
    
     Adım Adım Algoritma Çalışması:
     1. Başlangıç: myArray = {3, 5, 7, 4, 3, 7, 5}, result = 0
    
     Adım | i | myArray[i] | result öncesi | XOR İşlemi        | result sonrası
     -----|---|------------|---------------|-------------------|---------------
     1    | 0 | 3          | 0             | 0 ^ 3             | 3
     2    | 1 | 5          | 3             | 3 ^ 5             | 6
     3    | 2 | 7          | 6             | 6 ^ 7             | 1
     4    | 3 | 4          | 1             | 1 ^ 4             | 5
     5    | 4 | 3          | 5             | 5 ^ 3             | 6
     6    | 5 | 7          | 6             | 6 ^ 7             | 1
     7    | 6 | 5          | 1             | 1 ^ 5             | 4
    
     Sonuç: result = 4 (Dizide yalnızca bir kez bulunan sayı)
*/