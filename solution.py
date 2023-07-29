Here is a Python console application that solves the problem:

```python
def can_segment_string(s, dictionary):
    if s == "":
        return True

    string_length = len(s)
    for i in range(1, string_length + 1):
        sub = s[0:i]
        if sub in dictionary:
            if can_segment_string(s[i:string_length], dictionary):
                return True

    return False

def main():
    dictionary = set(input("Enter dictionary words separated by space: ").split())
    s = input("Enter the string to be segmented: ")
    if can_segment_string(s, dictionary):
        print("Yes")
    else:
        print("No")

if __name__ == "__main__":
    main()
```

This console application first asks the user to input the dictionary words separated by space. It then asks the user to input the string to be segmented. The application then checks if the string can be segmented into words from the dictionary and prints "Yes" if it can, "No" otherwise.