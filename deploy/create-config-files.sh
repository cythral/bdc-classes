#!/bin/bash

image=$1
cwd=$(dirname "${BASH_SOURCE[0]}")

for file in $(ls ${cwd}/params/*.json); do
    envName=$(echo $file | xargs basename | sed "s/\.json//")
    params=$(cat $file)
    params=$(echo $params | jq ".Image=\"$image\"")

    config=$(cat $cwd/config.json | jq --argjson params "$params" '.Parameters=$params')
    echo $config > bdc-classes.${envName}.config.json
done