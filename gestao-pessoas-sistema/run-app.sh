#!/bin/bash

# Definir diretório base
BASE_DIR="$(pwd)"
echo "📂 Diretório base: $BASE_DIR"

# Variáveis de ambiente
BACKEND_DIR="$BASE_DIR/backend/src"
FRONTEND_DIR="$BASE_DIR/frontend"
BACKEND_PORT=5001
FRONTEND_PORT=3000

# Cores para output
GREEN='\033[0;32m'
BLUE='\033[0;34m'
RED='\033[0;31m'
NC='\033[0m'

# Verificar se os diretórios existem
if [ ! -d "$BACKEND_DIR" ]; then
    echo -e "${RED}❌ Diretório do backend não encontrado: $BACKEND_DIR${NC}"
    exit 1
fi

if [ ! -d "$FRONTEND_DIR" ]; then
    echo -e "${RED}❌ Diretório do frontend não encontrado: $FRONTEND_DIR${NC}"
    exit 1
fi

# Função para verificar se um processo está rodando na porta
check_port() {
    lsof -i:$1 > /dev/null 2>&1
    return $?
}

# Função para iniciar o backend
start_backend() {
    echo -e "${BLUE}📦 Iniciando o Backend...${NC}"
    cd "$BACKEND_DIR" || exit
    
    echo "🔨 Restaurando dependências..."
    dotnet restore
    
    echo "🏗️ Buildando o projeto..."
    dotnet build
    
    echo "🌐 Iniciando a API..."
    dotnet run &
    cd "$BASE_DIR" || exit
}

# Função para iniciar o frontend
start_frontend() {
    echo -e "${BLUE}🎨 Iniciando o Frontend...${NC}"
    cd "$FRONTEND_DIR" || exit
    
    if [ ! -d "node_modules" ]; then
        echo "📦 Instalando dependências do Frontend..."
        npm install
    fi
    
    echo "🚀 Iniciando o servidor React..."
    npm start &
    cd "$BASE_DIR" || exit
}

# Limpar processos anteriores
if check_port $BACKEND_PORT; then
    echo -e "${RED}⚠️ Porta $BACKEND_PORT em uso. Finalizando processo...${NC}"
    kill $(lsof -t -i:$BACKEND_PORT) 2>/dev/null
fi

if check_port $FRONTEND_PORT; then
    echo -e "${RED}⚠️ Porta $FRONTEND_PORT em uso. Finalizando processo...${NC}"
    kill $(lsof -t -i:$FRONTEND_PORT) 2>/dev/null
fi

# Iniciar aplicações
start_backend
start_frontend

echo -e "${GREEN}✅ Sistema iniciado com sucesso!${NC}"
echo -e "${GREEN}📝 Acessos:${NC}"
echo -e "   Backend API: https://localhost:$BACKEND_PORT"
echo -e "   Swagger UI: https://localhost:$BACKEND_PORT/swagger"
echo -e "   Frontend: http://localhost:$FRONTEND_PORT"

# Aguardar término dos processos
trap 'kill $(jobs -p)' EXIT
wait