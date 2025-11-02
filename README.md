# 🧠 C# Collections Training

This project contains a set of **C# collection exercises** designed to help understand and practice fundamental data structures such as:
`Hashtable`, `Dictionary`, `SortedList`, `SortedDictionary`, `HashSet`, and `SortedSet`.

Each question focuses on solving a small real-world problem using C# collections.

---

## 📚 Project Structure

All exercises are implemented inside the file:

Each question is wrapped in a `#region` block (from Q1 to Q13) for easy navigation and testing.

---

## 🧩 Topics Covered

- Arrays and Frequency Counting  
- HashTable operations (search, swap keys/values)  
- Dictionary operations and filtering  
- SortedList / SortedDictionary manipulation  
- HashSet and SortedSet basics  
- Set operations (Union, Duplicates)  
- Working with user input and data lookup  
---

## 📘 Learning Outcomes

###  Q1 – Frequency Counter Using Hashtable
**Goal:** Count how many times each integer appears in an array.  
**Key Concepts:**  
- Using `Hashtable` to store key-value pairs.  
- Counting frequencies efficiently with O(n) complexity.  

---

###  Q2 – Find Key with the Highest Value
**Goal:** Find the key associated with the largest integer value in a hashtable.  
**Key Concepts:**  
- Iterating through `DictionaryEntry`.  
- Tracking maximum values in key-value structures.  

---

###  Q3 – Find Keys by Target Value
**Goal:** Print all keys matching a specific target value entered by the user.  
**Key Concepts:**  
- Reverse lookup in a `Hashtable`.  
- Handling "key not found" conditions gracefully.  

---

###  Q4 – Group Anagrams
**Goal:** Group words that are anagrams of each other.  
**Key Concepts:**  
- Using sorted characters as a unique key.  
- Grouping similar elements using lists inside a hashtable.  

---

###  Q5 – Detect Duplicates in an Array
**Goal:** Check whether a list of integers contains duplicates.  
**Key Concepts:**  
- Using `Hashtable` to track seen numbers.  
- Early exit for optimization when duplicates are found.  

---

###  Q6 – Student Directory (SortedDictionary)
**Goal:** Manage students by their IDs in sorted order.  
**Key Concepts:**  
- Using `SortedDictionary<int, string>`.  
- Add, remove, and retrieve data efficiently while maintaining order.  

---

###  Q7 – Employee Directory (SortedList)
**Goal:** Store and manage employee records sorted by ID.  
**Key Concepts:**  
- Working with `SortedList<TKey, TValue>`.  
- Sorting and retrieval in ascending key order.  

---

###  Q8 – Find Missing Numbers
**Goal:** Identify missing numbers from a sequence 1..N.  
**Key Concepts:**  
- Using mathematical summation formula.  
- Detecting missing elements without loops or nested comparisons.  

---

###  Q9 – Unique Elements Using HashSet
**Goal:** Remove duplicates from a list.  
**Key Concepts:**  
- `HashSet` automatically ensures uniqueness.  
- Efficient O(1) insert and lookup operations.  

---

### 🔹 Q10 – Swap Hashtable Keys and Values
**Goal:** Create a new hashtable with keys and values swapped.  
**Key Concepts:**  
- Iterating and reconstructing a new `Hashtable`.  
- Handling unique values constraint.  

---

###  Q11 – Union of Two Sets
**Goal:** Return the union of two sets (unique elements from both).  
**Key Concepts:**  
- Using `HashSet.UnionWith()`.  
- Understanding basic set theory operations.  

---

### 🔹 Q12 – Count Keys Starting with a Character
**Goal:** Count how many dictionary keys begin with a specific character.  
**Key Concepts:**  
- Working with `Dictionary<string, int>`.  
- String operations (`StartsWith`).  

---

###  Q13 – Filter Elements Greater Than Target
**Goal:** Find all elements greater than a user-given number in a sorted set.  
**Key Concepts:**  
- Using `SortedSet<int>`.  
- Filtering values and storing results in a `List<int>`.  

---

## 🧩 Technologies & Concepts Covered
- C# Collections (`Hashtable`, `Dictionary`, `HashSet`, `SortedList`, `SortedSet`, `SortedDictionary`)
- Control Flow (`foreach`, `if`, `break`)
- Data Manipulation
- Algorithmic Thinking
- Problem Solving in C#

---
## 📂 Repository Purpose
This repository serves as a **practical reference and learning resource** for mastering C# collections, suitable for:
- Students preparing for C# or data structure exams.  
- Developers revising for technical interviews.  
- Anyone aiming to understand how different collection types solve real-world problems.

---

## ⚙️ Requirements

- **.NET SDK 6.0 or higher**
- Any IDE (Visual Studio / VS Code / Rider)

---

👨‍💻 Author
Abdalla Adel Aboaziz
Backend Developer (.NET)
