
isFinished = False
nums = [5,3,1,2,4]



def maxSort(array):
    # Traverse through all array elements
    length = len(array)
    maxNum = array[0]

    for j in array:
            for i in array:
                if i > maxNum:
                        maxNum = i
                        array.append(array.pop(array.index(i)))
                
maxSort(nums)

for i in nums:
    print(i)

