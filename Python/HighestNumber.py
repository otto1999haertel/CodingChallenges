def __find_highest__(input):
    global high
    highest =0
    if(len(input)==0):
        return
    if(len(input)==1):
        return input[0]
    if(input[-1]>input[-2]):
        highest = input[-1]
        input.pop(-1)
        input.pop(-1)
    else:
        highest = input[-2]
        input.pop(-1)
        input.pop(-1)
    recursion = __find_highest__(input)
    if recursion is None:
        return highest
    if highest > recursion:
        return highest
    else:
        return recursion

    
    
    print()






if __name__ == "__main__":
    print("Hello World")
    assert(__find_highest__([-1, 3, 5, 6, 99, 12, 2])==99)
    assert(__find_highest__([0, 12, 4, 87])==87)
    assert(__find_highest__([8])==8)