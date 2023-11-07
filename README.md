# Codility-Dominator
An array A consisting of N integers is given.</br>
The dominator of array A is the value that occurs in more than half of the elements of A.

For example, consider array A such that</br>
A[0] = 3    A[1] = 4    A[2] =  3</br>
A[3] = 2    A[4] = 3    A[5] = -1</br>
A[6] = 3    A[7] = 3</br>

The dominator of A is 3 because it occurs in 5 out of 8 elements of A</br> 
(namely in those with indices 0, 2, 4, 6 and 7) and 5 is more than a half of 8.

Write a function</br>
class Solution { public int solution(int[] A); }</br>
that, given an array A consisting of N integers, returns index of any element of array A in which the dominator of A occurs.</br> 
The function should return −1 if array A does not have a dominator.

For example, given array A such that</br>
A[0] = 3    A[1] = 4    A[2] =  3</br>
A[3] = 2    A[4] = 3    A[5] = -1</br>
A[6] = 3    A[7] = 3</br>
the function may return 0, 2, 4, 6 or 7, as explained above.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [0..100,000];</br>
each element of array A is an integer within the range [−2,147,483,648..2,147,483,647].
