input = open("input.txt", "r").read()

def get_history(moves):
    x = 0
    y = 0
    history = []

    for move in moves:
        if move == "^":
            y +=1
        elif move == "v":
            y -= 1
        elif move == "<":
            x -= 1
        elif move == ">":
            x += 1

        history.append((x, y))

    return history


def part_1():
    history = get_history(input)
    history = list(dict.fromkeys(history))
    print(len(history))

def part_2():
    santa_history = get_history(input[::2])
    robot_santa_history = get_history(input[1::2])
    shared_history = santa_history + robot_santa_history
    shared_history = list(dict.fromkeys(shared_history))
    print(len(shared_history))

part_1()
part_2()