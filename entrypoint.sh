#!/bin/bash

decrypt() {
    ciphertext=$1
    tempfile=$(mktemp)

    echo $ciphertext | base64 --decode > $tempfile
    echo $(aws kms decrypt --ciphertext-blob fileb://$tempfile --query Plaintext --output text | base64 --decode)
    rm $tempfile;
}

export DB_PASSWORD=$(decrypt $ENCRYPTED_DB_PASSWORD)
export SVC_PASSWORD=$(decrypt $ENCRYPTED_SVC_PASSWORD)

dotnet /app/BrekkeDanceCenter.Classes.dll