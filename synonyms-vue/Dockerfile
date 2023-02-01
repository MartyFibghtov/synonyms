FROM node:14

WORKDIR /app
COPY package*.json ./
RUN npm install --only=production
COPY . .
RUN npm run build

EXPOSE 8080
ENV NODE_ENV=production
ENV DISABLE_ESLINT_PLUGIN=true

CMD ["npm", "run", "serve"]