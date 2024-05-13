import random


def update_scoreboard(result, scoreboard):
  if result == "win":
    scoreboard["wins"] += 1
  else:
    scoreboard["losses"] += 1


def print_scoreboard(scoreboard):
  print("Wins:", scoreboard["wins"])
  print("Losses:", scoreboard["losses"])


items = ["rock", "paper", "scissors"]
actions = random.choice(items)
scoreboard = {
    "wins": 0,
    "losses": 0,
}

while True:
  user = input('Enter a choice (rock, paper, scissors): ')

  print('You chose', user, 'computer chose', actions)

  if user == actions:
    print(f"Both players selected {user}. It's a tie!")
  elif (user == "rock" and actions == "scissors") or \
     (user == "paper" and actions == "rock") or \
     (user == "scissors" and actions == "paper"):
    print(f"{user} beats {actions}! You win!")
    update_scoreboard("win", scoreboard)
  else:
    print(f"{actions} beats {user}! You lose.")
    update_scoreboard("loss", scoreboard)

  print_scoreboard(scoreboard)

  play_again = input("Do you want to play again? (y/n): ")
  if play_again.lower() != 'y':
    break
