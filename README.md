# Odd Number Out in Series

## *Description*

This project solves the problem of finding the number that doesn't follow the majority pattern in a given series. The series contains mostly even or mostly odd numbers, and the task is to find the number that is different from the rest.

### *Problem Statement*

Given a series of integers, identify the number that doesn't belong to the pattern. The pattern could be either that all numbers are even or all numbers are odd. You need to return the number that doesn't fit the majority.

### *Example*

#### *Example 1:*

*Input:*

{2, 4, 6, 8, 9, 10}

*Output:*

9 (Because it's an odd number while the rest are even)

#### *Example 2:*

*Input:*

{1, 2, 3, 5, 7, 9, 10}

*Output:*

10 (Because it's an even number, while the rest are odd)

---

### *How the Code Works*

1. *Count the Even and Odd Numbers:*
   The program counts how many numbers are even and how many are odd.

2. *Identify the Outlier:*
   - If there are more even numbers, the program finds and returns the first odd number.
   - If there are more odd numbers, it finds and returns the first even number.

3. The program uses *LINQ* in C# for counting even and odd numbers.

### *Technologies Used*
- *C#*

### *Instructions to Run the Program*

1. Clone this repository to your local machine:
    bash
    git clone <repository-link>
    

2. Open the project in *Visual Studio* or any other C# IDE.

3. Open the OddNumberOut.cs file.

4. Compile and run the program.

5. You will be prompted to enter the size of the series and the numbers in the series.

6. The program will output the number that doesn't belong to the series.

### *Usage Example:*

```bash
Enter the size of the series:
7
Enter the elements of the series:
2
4
6
8
9
10
The number that doesn't belong to the series is: 9
