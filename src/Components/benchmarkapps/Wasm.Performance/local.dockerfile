FROM selenium/standalone-chrome:3.141.59-mercury as final
COPY ./Driver/bin/Release/netcoreapp3.1/linux-x64/publish ./

# Supervisor configuration file
COPY /Driver/wasm.performance.conf /etc/supervisor/conf.d/