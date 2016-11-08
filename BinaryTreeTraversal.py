# Define a node
class node():   
    def __init__(self, v, l, r):
        self.val = v
        self.left = l
        self.right = r

# Build our tree
n10 = node(5, None, None)
n9 = node(11, None, None)
n8 = node(2, None, None)
n7 = node(7, n10, None)
n6 = node(3, None, None)
n5 = node(9, n8, n9)
n4 = node(4, n6, n7)
n3 = node(8, n4, n5)
n2 = node(1, None, None)
n1 = node(6, n2, n3)

# implementation of a Queue
class queue():
    def __init__(self):
        self.q = []
    
    def put(self, v):
        self.q.insert(0, v)

    def get(self):
        return self.q.pop()
    
    def empty(self):
        return len(self.q) <= 0

# implementation of a Stack
class stack():
    def __init__(self):
        self.s = []
    
    def push(self, v):
        self.s.insert(0, v)
    
    def pop(self):
        return self.s.pop(0)

    def empty(self):
        return len(self.s) <= 0

q = queue()

# Breadth first traversal
def bf_traverse(n):
    
    q.put(n)

    while(not q.empty()):

        n = q.get()
        print(n.val)

        if (n.left):
            q.put(n.left)

        if (n.right):
            q.put(n.right)
        
s = stack()

# Depth first traversal
def df_traverse(n):
    s.push(n)

    while(not s.empty()):
        n = s.pop()
        print(n.val)

        if (n.left):
            s.push(n.left)
        if (n.right):
            s.push(n.right)

bf_traverse(n1)
print('\n')
df_traverse(n1)