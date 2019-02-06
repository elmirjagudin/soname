PLUGINS := ../unity/Assets/Plugins

SO := libfoo.so.1 libfoo.so libbar.so

all: $(SO)

libfoo.so.1: foo.c
	$(CC) -shared -fPIC foo.c -Wl,-soname,libfoo.so.1 -o libfoo.so.1

libfoo.so: libfoo.so.1
	ln -s libfoo.so.1 libfoo.so

libbar.so: bar.c libfoo.so
	$(CC) -shared -fPIC bar.c -Wl,-rpath=. -o libbar.so -L. -lfoo

install: $(SO)
	mkdir -p $(PLUGINS)
	cp $(SO) $(PLUGINS)/

clean:
	rm -f $(SO)
