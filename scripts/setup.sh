#!/bin/bash
set -e

echo "🔧 Setting up environment..."
apt-get update && apt-get install -y make git curl vim
pip install --upgrade pip
pip install black pytest || true
echo "✅ Setup complete!"
