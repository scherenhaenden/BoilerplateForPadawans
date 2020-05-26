# HOW TO USE GIT
- [X] How to install
- [X] How to clone this project
- [X] Add important links


## Installing *Git* on *Linux*

Determine on **which *Linux* distribution** your system is based on. See [List of Linux distributions – Wikipedia](http://en.wikipedia.org/wiki/List_of_Linux_distributions) for a list. **Most *Linux* systems – including *Ubuntu* – are *Debian*-based**.


### *Debian*-based linux systems

**[Open a terminal window](https://help.ubuntu.com/community/UsingTheTerminal). Copy & paste the following** into the terminal window and **hit `Return`**. You may be prompted to enter your password.

```shell
sudo apt-get update
sudo apt-get upgrade
sudo apt-get install git
```

**You can use *Git* now.**


### *Red Hat*-based linux systems

**Open a terminal. Copy & paste the following** into the terminal window and **hit `Return`**. You may be prompted to enter your password.

```shell
sudo yum upgrade
sudo yum install git
```

**You can use *Git* now.**

## Installing *Git* on a *Mac*

[Open a terminal window](http://www.youtube.com/watch?v=zw7Nd67_aFw).

### Step 1 – Install [*Homebrew*](http://brew.sh/)

> *Homebrew* […] simplifies the installation of software on the Mac OS X operating system.

– [Homebrew – Wikipedia](http://en.wikipedia.org/wiki/Homebrew_%28package_management_software%29)

**Copy & paste the following** into the terminal window and **hit `Return`**.

```shell
/usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"
brew doctor
```

You will be offered to install the *Command Line Developer Tools* from *Apple*. **Confirm by clicking *Install***. After the installation finished, continue installing *Homebrew* by **hitting `Return`** again.

### Step 2 – Install *Git*

**Copy & paste the following** into the terminal window and **hit `Return`**.

```shell
brew install git
```

**You can use *Git* now.**

## Installing *Git* on Windows

1. **Download** *Git* from [Git for Windows](https://gitforwindows.org) and **install Git Bash**.

**You can use *Git* now.**


# Clone this Project

Select a directory to download (clone) your project

```console
foo@bar:~$ git clone https://github.com/scherenhaenden/BoilerplateForPadawans.git
```
To enter in the directory of the project use

```console
foo@bar:~$ cd ./BoilerplateForPadawans
```


# Important links

[Git man](https://manpages.debian.org/stretch/git-man/git.1.en.html)

[Git flow](https://danielkummer.github.io/git-flow-cheatsheet/)



