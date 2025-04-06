#!/bin/sh
echo -ne '\033c\033]0;Lost\a'
base_path="$(dirname "$(realpath "$0")")"
"$base_path/Lost.arm64" "$@"
