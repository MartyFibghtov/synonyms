FROM node:14

EXPOSE 8080
ENV DISABLE_ESLINT_PLUGIN=true
WORKDIR /app
COPY package*.json ./
RUN npm install
COPY . .
RUN npm run build
CMD [ "npm", "run", "serve" ]