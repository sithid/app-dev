CC = gcc
CFLAGS = -Wall -Werror -I include

SRCS = hello.c

all: hello

hello: $(SRCS)
	$(CC) $(CFLAGS) -o $@ $^

clean:
	rm -f hello
