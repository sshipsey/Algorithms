# Merge the values between p and r into the array in sorted order
def merge(A, p, q, r):

    # Split our list into a left and right side
    L = A[p : q + 1]
    R = A[q + 1 : r + 1]

    # This is a "sentinel" that is used to always take off the other side once our left or right is consumed
    L.append(1e304)
    R.append(1e304)

    # Insert values from our L and R half into our list in sorted order
    i = 0
    j = 0    
    for k in range(p, r + 1):
        if (L[i] <= R[j]):
            A[k] = L[i]
            i += 1
        else:
            A[k] = R[j]
            j += 1

# Continue splitting the list until you have individual values and then call merge to replace them in the list sorted
def mergesort(A, p, r):
    if (p < r):
        q = (p + r) // 2
        mergesort(A, p, q)
        mergesort(A, q + 1, r)
        merge(A, p, q, r)

arr = [1, 4, 3, 2, 7, 5, 3, 8]
mergesort(arr, 0, len(arr) - 1)
print(arr)