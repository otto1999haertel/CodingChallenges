#https://edabit.com/challenge/NNhkGocuPMcryW7GP
def square_areas_difference(radius):
    a_bigger_square = (2*radius)**2
    a_smaller_suqare = ((2*radius)**2)/2
    return a_bigger_square-a_smaller_suqare


if __name__=="__main__":
    print("Circly Square Challenge")
    assert(square_areas_difference(5)== 50)
    assert(square_areas_difference(6)== 72)
    assert(square_areas_difference(7)== 98)
    assert(square_areas_difference(17)== 578)