import tcod as libtcod

# Game settings
SCREEN_WIDTH = 80
SCREEN_HEIGHT = 50
MAP_WIDTH = 80
MAP_HEIGHT = 45
LIMIT_FPS = 20

# Colors
color_dark_wall = libtcod.Color(0, 0, 100)
color_dark_ground = libtcod.Color(50, 50, 150)


# Initialize map
def make_map():
    global map

    map = [[Tile(True) for y in range(MAP_HEIGHT)] for x in range(MAP_WIDTH)]

    for x in range(30, 50):
        for y in range(22, 38):
            map[x][y].blocked = True
            map[x][y].block_sight = True


# Check if a tile is blocked
def is_blocked(x, y):
    if map[x][y].blocked:
        return True
    return False


class Tile:
    def __init__(self, blocked, block_sight=None):
        self.blocked = blocked
        if block_sight is None:
            block_sight = blocked
        self.block_sight = block_sight


class Player:
    def __init__(self, x, y, char, color):
        self.x = x
        self.y = y
        self.char = char
        self.color = color

    def move(self, dx, dy):
        if not is_blocked(self.x + dx, self.y + dy):
            self.x += dx
            self.y += dy


def handle_keys():
    key = libtcod.console_check_for_keypress()

    if key.vk == libtcod.KEY_ESCAPE:
        return True

    if key.vk == libtcod.KEY_UP:
        player.move(0, -1)
    elif key.vk == libtcod.KEY_DOWN:
        player.move(0, 1)
    elif key.vk == libtcod.KEY_LEFT:
        player.move(-1, 0)
    elif key.vk == libtcod.KEY_RIGHT:
        player.move(1, 0)

    return False


def main():
    libtcod.console_set_custom_font('arial10x10.png', libtcod.FONT_TYPE_GREYSCALE | libtcod.FONT_LAYOUT_TCOD)
    libtcod.console_init_root(SCREEN_WIDTH, SCREEN_HEIGHT, 'Roguelike Game', False)

    make_map()

    player = Player(SCREEN_WIDTH // 2, SCREEN_HEIGHT // 2, '@', libtcod.white)  # Definicja gracza

    while not libtcod.console_is_window_closed():
        libtcod.console_set_default_foreground(0, libtcod.white)
        libtcod.console_put_char(0, player.x, player.y, player.char, libtcod.BKGND_NONE)
        libtcod.console_flush()
        libtcod.console_put_char(0, player.x, player.y, ' ', libtcod.BKGND_NONE)

        exit_game = handle_keys()
        if exit_game:
            break


if __name__ == '__main__':
    main()