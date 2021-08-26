param (
    [string]$prefix = "ben2code", 
    [string]$tag = "latest"
    )

$builddate = "2021-08-26"
$buildversion = "1.1"


$container = "DemandAPI"
$latest = "{0}/{1}:{2}" -f $prefix, $container, $tag 
$versioned = "{0}/{1}:{2}" -f $prefix, $container, $buildversion
docker build . -f .\DemandAPI\Dockerfile -t $latest -t $versioned --build-arg BUILD_DATE=$builddate --build-arg BUILD_VERSION=$buildversion
docker push $versioned
docker push $latest 

$container = "DemandeClient"
$latest = "{0}/{1}:{2}" -f $prefix, $container, $tag 
$versioned = "{0}/{1}:{2}" -f $prefix, $container, $buildversion
docker build . -f .\DemandeClient\Dockerfile -t $latest -t $versioned --build-arg BUILD_DATE=$builddate --build-arg BUILD_VERSION=$buildversion
docker push $versioned
docker push $latest 