def _find_highest_(input):
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
    recursion = _find_highest_(input)
    if recursion is None:
        return highest
    if highest > recursion:
        return highest
    else:
        return recursion

def _reverse_string_(input):
    
    if(len(input)==0):
        return ""
    return _reverse_string_(input[1:]) + input[0]




if __name__ == "__main__":
    print("Hello World")
    assert(_find_highest_([-1, 3, 5, 6, 99, 12, 2])==99)
    assert(_find_highest_([0, 12, 4, 87])==87)
    assert(_find_highest_([8])==8)
    assert(_reverse_string_("hello")=="olleh")