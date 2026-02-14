def _addingNumbers(numA, numB):
    if(len(numA)!=len(numB)):
        return "Invalid Operation"
    res=""
    for i in range(len(numA)):
        res+= str(int(numA[i]) + int(numB[i]))
    return res




if __name__ == "__main__":
    print("Hello World")
    assert(_addingNumbers("111", "111")=="222")
    assert(_addingNumbers("10", "80")=="90")
    assert(_addingNumbers("", "20") == "Invalid Operation")