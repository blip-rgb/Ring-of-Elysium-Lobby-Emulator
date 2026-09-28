# Ring of Elysium — Local Lobby Loader

A small community project that emulates the initial server communication required to load the **Ring of Elysium** game lobby.

This project is **not a game server** and does not implement any gameplay or server-side game functionality.

## Features

* Local communication: `127.0.0.1:9001`
* Single client connection
* Predefined protocol responses
* No game files included
* No client modification
* No gameplay, matchmaking or account functionality

## Requirements

* A legally obtained copy of **Ring of Elysium**.
* The game client should be the latest or near-latest Steam version for reliable operation.

## Usage

### 1. Start the lobby loader

Run the lobby loader first.

### 2. Create a client shortcut

Create a shortcut to `Europa_Client.exe` and add these launch parameters:

```text
-language=en -garena -uid=1 -server=127.0.0.1:9001
```

Example:

```text
Europa_Client.exe -language=en -garena -uid=1 -server=127.0.0.1:9001
```

### 3. Start the client

Launch `Europa_Client.exe` through the created shortcut.

### Launch order

1. Start the lobby loader.
2. Create/use the client shortcut with the parameters above.
3. Start the client through the shortcut.

## Disclaimer

This is an unofficial community project and is not affiliated with, endorsed by, or sponsored by Tencent or Aurora Studio.

Ring of Elysium and related trademarks are the property of their respective owners.

The project does not distribute the Ring of Elysium client or any proprietary game files.

The lobby loader does **not modify, patch, replace, or otherwise alter the original game files or the game client itself**.

## License

This project is licensed under the MIT License.
