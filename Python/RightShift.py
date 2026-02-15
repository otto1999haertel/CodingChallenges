#https://edabit.com/challenge/ALGbgMWLuEdrh22fB
def _shift_right(input, shift_value):
    return input // (1 << shift_value) # Floor Shift => Ganzzahlige Division mit Abrundung


if __name__ == "__main__":
    print("Right Shift Operations")
    assert(_shift_right(80,3)==10)
    assert(_shift_right(-24,2)==-6)
    assert(_shift_right(-5,1)==-3)
    assert(_shift_right(4666,6)==72)
    assert(_shift_right(3777,6)==59)
    assert(_shift_right(-512,10)==-1)