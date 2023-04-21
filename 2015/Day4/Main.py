from ast import Str
import hashlib

input = open("input.txt", "r").read().strip()

def process(crit):
    check = False
    count = 0

    while not check:
        r = input + str(count)
        result = hashlib.md5(bytes(r, encoding="utf-8")).hexdigest()
        if result[:len(crit)] == crit:
            check = True
            break
        else:
            count += 1

    return count

def part_1():
    print(process("00000"))

def part_2():
    print(process("000000"))

part_1()
part_2()