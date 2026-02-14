#https://edabit.com/challenge/ALGbgMWLuEdrh22fB
def _shift_right(input, shift_value):
    was_negative = False
    if(input<0):
        input=input*-1
        was_negative = True
    bin_num = "{0:b}".format(input)
    if(shift_value<len(bin_num)):       
        cutted_string = bin_num[:-shift_value]
        bin_converted = int(cutted_string,2)
        if(was_negative):
            return bin_converted*-1
        return bin_converted
    else:
        print("Error")


if __name__ == "__main__":
    print("Right Shift Operations")
    assert(_shift_right(80,3)==10)
    assert(_shift_right(-24,2)==-6)
    assert(_shift_right(-5,1)==-2)
    assert(_shift_right(4666,6)==72)
    assert(_shift_right(3777,6)==59)
    assert(_shift_right(-512,10)==-1)