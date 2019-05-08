import random 

nums = [None] * 10

for i in range (0,9):
    nums[i] = random.randint(0,1)
    print(nums[i])
