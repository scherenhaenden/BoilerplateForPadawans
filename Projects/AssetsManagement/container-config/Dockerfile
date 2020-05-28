 
#  1.- OS
#  2.- packages and repositories
#  3.- configuration
 
 #1.-
 FROM ubuntu:18.04 
 
# 2.-
RUN apt-get -qq clean  
RUN apt-get -qq update

RUN apt-get -qq -y install apt-utils
RUN apt-get -qq -y update
RUN apt-get -qq -y install sudo libterm-readline-gnu-perl apache2 iputils-ping net-tools

RUN apt-get -qq -y install autoconf build-essential git-core libtool unzip
RUN apt-get -qq -y install ssh bash apt-utils apt-transport-https software-properties-common curl supervisor vim apt-utils
RUN apt-get -qq -y dist-upgrade
RUN apt-get -qq update 
 
RUN sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF 
RUN sudo apt install apt-transport-https
RUN echo "deb https://download.mono-project.com/repo/ubuntu vs-bionic main" | sudo tee /etc/apt/sources.list.d/mono-official-vs.list
RUN sudo apt update
RUN apt-get -qq -y install mono-apache-server libapache2-mod-mono mono-xsp mono-apache-server4
RUN apt-get -qq -y install asp.net-examples mono-fastcgi-server

# 3.-

# Enable apache modules
RUN a2enmod proxy
RUN a2enmod proxy_http
RUN a2enmod proxy_balancer
RUN a2enmod lbmethod_byrequests
RUN a2enmod ssl
RUN a2enmod rewrite
RUN a2enmod rewrite headers suexec

RUN a2enmod mod_mono
RUN a2dismod mod_mono
RUN /etc/init.d/apache2 restart
RUN a2enmod mod_mono
RUN /etc/init.d/apache2 restart

RUN rm /tmp/mod_mono*
## assets-management.conf
ADD assets-management.conf /etc/apache2/sites-available/assets-management.com.conf
ADD ports.conf /etc/apache2/ports.conf
RUN sudo a2ensite assets-management.com.conf

RUN mkdir /tmp/public/
RUN sudo chmod 777 /tmp/public/
RUN sudo chmod 777 /tmp/

ADD run.sh /run.sh
RUN chmod 755 /*.sh
RUN apt-get -qq -y dist-upgrade

RUN ipcs -s | grep $USERNAME | perl -e 'while (<STDIN>) { @a=split(/\s+/); print `ipcrm sem $a[1]`}'
RUN /etc/init.d/apache2 restart

# Expose Ports
EXPOSE 80 443
RUN apt-get update

# Keep Docker machine alive (replace with run.sh -> supervisor)
ENTRYPOINT /run.sh
